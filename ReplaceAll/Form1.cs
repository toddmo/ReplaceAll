using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReplaceAll
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private string highlight;

    private List<FileSystemInfo> _results;
    public List<FileSystemInfo> Results
    {
      get { return _results; }
      set
      {
        _results = value;
        LoadFindResults();
      }
    }

    private void LoadFindResults()
    {
      rtbFile.Clear();
      lstFiles.Items.Clear();
      foreach (FileSystemInfo fileSystemInfo in Results)
      {
        lstFiles.Items.Add(fileSystemInfo);
      }
    }

    private void btnBrowseSource_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        txtSource.Text = folderBrowserDialog1.SelectedPath;
    }

    private void btnBrowseTarget_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        txtTarget.Text = folderBrowserDialog1.SelectedPath;
    }

    private void btnFind_Click(object sender, EventArgs e)
    {
      Find();
    }

    private void Find()
    {
      lstFiles.DisplayMember = "FullName";
      Results = Find(new DirectoryInfo(txtSource.Text), txtMatch.Text);
      btnReplace.Enabled = true;
    }

    private bool DirectoryMatches(DirectoryInfo directoryInfo, string match)
    {
      return directoryInfo.Name.Contains(match, StringComparison.OrdinalIgnoreCase);
    }

    private bool ExcludeDirectory(DirectoryInfo directoryInfo)
    {
      return txtExcludeDirectories.Text.Split(new char[] {','},
        StringSplitOptions.RemoveEmptyEntries).Contains(directoryInfo.Name);
    }

    private bool FileTextMatches(FileInfo fileInfo, string match)
    {
      if (!chkReplaceInFiles.Checked) return false;

      using (var streamReader = fileInfo.OpenText())
      {
        return streamReader.ReadToEnd().Contains(match, StringComparison.OrdinalIgnoreCase);
      }
    }

    private bool FileNameMatches(FileInfo fileInfo, string match)
    {
      return fileInfo.Name.Contains(match, StringComparison.OrdinalIgnoreCase);
    }

    private List<FileSystemInfo> Find(DirectoryInfo directoryInfo, string match)
    {
      highlight = match;
      var results = new List<FileSystemInfo>();

      if (ExcludeDirectory(directoryInfo)) 
        return results;

      if (DirectoryMatches(directoryInfo,match))
        results.Add(directoryInfo);

      results.AddRange(directoryInfo.GetFiles().Where(x => FileMatches(x,match)));

      foreach (var childDirectory in directoryInfo.GetDirectories())
        results.AddRange(Find(childDirectory, match));

      return results;
    }

    private bool FileMatches(FileInfo fileInfo, string match)
    {
      return FileNameMatches(fileInfo,match) || FileTextMatches(fileInfo,match);
    }

    private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      PreviewFile((FileSystemInfo)lstFiles.SelectedItem);
    }

    private void PreviewFile(FileSystemInfo fileSystemInfo)
    {
      rtbFile.Clear();
      var fileInfo = fileSystemInfo as FileInfo;
      if (fileInfo == null) return;

      var streamReader = fileInfo.OpenText();
      var text = streamReader.ReadToEnd();
      streamReader.Close();
      rtbFile.Text = text.Replace("\r", "\r\n");
      var matches = Regex.Matches(text, highlight, RegexOptions.IgnoreCase);
      foreach (Match match in matches)
      {
        rtbFile.SelectionStart = match.Index;
        rtbFile.SelectionLength = match.Length;
        rtbFile.SelectionColor = Color.DodgerBlue;
      }
      if (matches.Count > 0)
      {
        rtbFile.SelectionStart = matches[0].Index + matches[0].Length;
      }
      rtbFile.SelectionLength = 0;
      rtbFile.ScrollToCaret();
    }

    private void lstFiles_DrawItem(object sender, DrawItemEventArgs e)
    {
      var g = e.Graphics;

      if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        e = new DrawItemEventArgs(g,
                                  e.Font,
                                  e.Bounds,
                                  e.Index,
                                  e.State ^ DrawItemState.Selected,
                                  e.ForeColor,
                                  lstFiles.ForeColor);//Choose the color
      e.DrawBackground();

      var fileSystemInfo = (FileSystemInfo)lstFiles.Items[e.Index];
      var fileInfo = fileSystemInfo as FileInfo;
      Color foreColor;
      if (fileInfo != null)
      {
        var streamReader = fileInfo.OpenText();
        var text = streamReader.ReadToEnd();
        streamReader.Close();
        foreColor =
          text.Contains(highlight, StringComparison.OrdinalIgnoreCase) ?
          Color.DodgerBlue :
          Color.LimeGreen;
      }
      else
        foreColor = Color.Orange;

      g.DrawString(fileSystemInfo.FullName,
        lstFiles.Font,
        new SolidBrush(foreColor),
        new PointF(e.Bounds.X, e.Bounds.Y));

      e.DrawFocusRectangle();
    }

    private void btnReplace_Click(object sender, EventArgs e)
    {
      var source = new DirectoryInfo(txtSource.Text);
      var targetParent = new DirectoryInfo(txtTarget.Text);
      var target = new DirectoryInfo(Path.Combine(targetParent.FullName, source.Name));
      if (target.Exists)
      {
        if (MessageBox.Show("Destination already exists. Must Delete it to continue. OK?", "Confirm Delete",
              MessageBoxButtons.OKCancel) == DialogResult.OK)
          target.Delete(true);
        else
          return;
      }

      target = CopyFilesRecursively(source, targetParent);
      ReplaceAllIn(target);
      Results = Find(target, txtReplacement.Text);
    }

    private void ReplaceAllIn(DirectoryInfo directoryInfo)
    {
      var match = txtMatch.Text;
      var regex = new Regex(match, RegexOptions.IgnoreCase);
      if (DirectoryMatches(directoryInfo,match))
        Replace(directoryInfo, regex);

      foreach (var fileInfo in directoryInfo.GetFiles())
      {
        if (FileMatches(fileInfo,match))
          Replace(fileInfo, regex);

        if (FileTextMatches(fileInfo,match))
          ReplaceText(fileInfo, regex);
      }

      foreach (var childDirectory in directoryInfo.GetDirectories())
        ReplaceAllIn(childDirectory);

    }

    private void Replace(DirectoryInfo directoryInfo, Regex regex)
    {
      var newName = regex.Replace(directoryInfo.Name, m => Replacement(m.Value));
      directoryInfo.RenameTo(newName);
    }

    private void Replace(FileInfo fileInfo, Regex regex)
    {
      var newName = regex.Replace(fileInfo.Name, m => Replacement(m.Value));
      fileInfo.RenameTo(newName);
    }

    private void ReplaceText(FileInfo fileInfo, Regex regex)
    {
      using (var streamReader = fileInfo.OpenText())
      {
        var text = streamReader.ReadToEnd();
        streamReader.Close();
        var newText = regex.Replace(text, m => Replacement(m.Value));
        var attributes = fileInfo.Attributes;
        fileInfo.Attributes = FileAttributes.Normal;
        File.WriteAllText(fileInfo.FullName, newText);
        fileInfo.Attributes = attributes;
      }
    }
    private string Replacement(string text)
    {
      string replacement = txtReplacement.Text;
      if (chkRetainCase.Checked == false)
        return replacement;

      if (text.ToUpper() == text)
        replacement = txtReplacement.Text.ToUpper();
      else if (text.ToLower() == text)
        replacement = txtReplacement.Text.ToLower();
      else
      {
        replacement = txtReplacement.Text;
      }
      return replacement;

    }

    private DirectoryInfo CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
    {
      if (ExcludeDirectory(source))
        return source;
      var newDirectoryInfo = target.CreateSubdirectory(source.Name);
      foreach (var fileInfo in source.GetFiles())
        fileInfo.CopyTo(Path.Combine(newDirectoryInfo.FullName, fileInfo.Name));

      foreach (var childDirectoryInfo in source.GetDirectories())
        CopyFilesRecursively(childDirectoryInfo, newDirectoryInfo);

      return newDirectoryInfo;
    }
  }
}

public static class Extensions
{
  public static void RenameTo(this DirectoryInfo directoryInfo, string name)
  {
    if (directoryInfo == null)
    {
      throw new ArgumentNullException("directoryInfo", "Directory info to rename cannot be null");
    }

    if (string.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("New name cannot be null or blank", "name");
    }

    var destDirName = Path.Combine(directoryInfo.Parent.FullName, name);
    if (Directory.Exists(destDirName))
      Directory.Delete(destDirName, true);

    directoryInfo.MoveTo(destDirName);

  }

  public static void RenameTo(this FileInfo fileInfo, string name)
  {
    if (fileInfo == null)
    {
      throw new ArgumentNullException("fileInfo", "File info to rename cannot be null");
    }

    if (string.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("New name cannot be null or blank", "name");
    }

    fileInfo.MoveTo(Path.Combine(fileInfo.DirectoryName, name));

  }

  public static bool Contains(this string source, string toCheck, StringComparison comp)
  {
    return source.IndexOf(toCheck, comp) >= 0;
  }
}