using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Comment
{
    public string CommenterName { get; set; }
    public string Content { get; set; }

    public Comment(string commenterName, string content)
    {
        CommenterName = commenterName;
        Content = content;
    }

    public override string ToString()
    {
        return $"*  {CommenterName}: {Content}";
    }
}

class Post
{
    public string PostName { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public List<Comment> Comments { get; set; }

    public Post(string postName)
    {
        PostName = postName;
        Likes = 0;
        Dislikes = 0;
        Comments = new List<Comment>();
    }
}
class SocialMediaPosts
{
    static void AddComment(Dictionary<string, Post> posts, string postName, string input, Regex pattern)
    {
        if (!posts.ContainsKey(postName))
        {
            return;
        }

        Match match = pattern.Match(input);

        string commenterName = match.Groups[2].Value;
        string content = match.Groups[3].Value;

        Comment comment = new Comment(commenterName, content);

        posts[postName].Comments.Add(comment);
    }

    static void Main(string[] args)
    {
        string input;

        Regex pattern = new Regex(@"(?:comment) ([a-zA-Z\d]+) ([a-zA-Z]+) (.+)");

        Dictionary<string, Post> posts = new Dictionary<string, Post>();

        while ((input = Console.ReadLine()) != "drop the media")
        {
            string[] items = input.Split(' ');

            string action = items[0];
            string postName = items[1];

            switch (action)
            {
                case "post":
                    posts[postName] = new Post(postName);
                    break;
                case "like":
                    if (posts.ContainsKey(postName))
                    {
                        posts[postName].Likes++;
                    }
                    break;
                case "dislike":
                    if (posts.ContainsKey(postName))
                    {
                        posts[postName].Dislikes++;
                    }
                    break;
                case "comment":
                    AddComment(posts, postName, input, pattern);
                    break;
                default:
                    break;
            }
        }

        foreach (KeyValuePair<string, Post> pair in posts)
        {
            string postName = pair.Key;
            int likes = pair.Value.Likes,
                dislikes = pair.Value.Dislikes;

            Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");
            Console.WriteLine("Comments:");
            Console.WriteLine(pair.Value.Comments.Any() ?  
                string.Join(Environment.NewLine, pair.Value.Comments) :
                "None");
        }
    }
}