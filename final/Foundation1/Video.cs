using System;
using System.Collections.Generic;
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public int GetNumComments()
    {
        return Comments.Count;
    }
}
