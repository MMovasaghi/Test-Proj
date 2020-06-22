# Test-Proj
Just For Test

This project is a MediaPlayer app can just run on windows os because it use some libraries that just supported on .net Framework.

* App image 
<p align="left">
  <img src="https://github.com/MMovasaghi/Test-Proj/blob/master/image.png" 
       width="70%" title="hover text">
</p>

Describing the code:

```
private string filepath;
```
This variable save the file path.

```
using (OpenFileDialog filedialog = new OpenFileDialog())
{
    if (filedialog.ShowDialog() == DialogResult.OK)
    {
        filepath = filedialog.FileName;
        axWindowsMediaPlayer1.URL = filepath;
    }
}
```
Then we create the `OpenFileDialog` to chose the file to open it, then check that it has correct value after selection.
Finally we send it to the player object to play it.
