namespace SegundoProjeto.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddPost(Post post) { Posts.Add(post); }
        public void RemovePost(Post post) { Posts.Remove(post); }
        public void AddComment(Comment comment) { Comments.Add(comment); }
        public void RemoveComment(Comment comment) { Comments.Remove(comment); }

    }
}
