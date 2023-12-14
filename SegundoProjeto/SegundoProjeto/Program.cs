using SegundoProjeto.Entities;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qtde de post: ");
            int nPost = int.Parse(Console.ReadLine());

            for (int i = 0; i < nPost; i++)
            {
                Console.Write("Titulo do post: ");
                string title = Console.ReadLine();
                DateTime date = DateTime.Now;
                Console.Write("Explique sua conteudo: ");
                string content = Console.ReadLine();
                Console.Write("Contidade de like: ");
                int likes = int.Parse(Console.ReadLine());

               Post post = new Post(date, title, content, likes);
                post.AddPost(post);

                Console.WriteLine("-----------------");
                Console.Write("Qtde de comentario: ");
                int nComment = int.Parse(Console.ReadLine());

                for (int  j = 0; j < nComment; j++)
                {
                    Console.Write("texto do comentario: ");
                    string text = Console.ReadLine();

                    Comment comment = new Comment(text);
                    post.AddComment(comment);
                }

                Console.WriteLine("-----------------");
                Console.WriteLine(post.Title);
                Console.WriteLine(post.Likes + " Likes, " + post.Moment);
                Console.WriteLine(post.Content);
                Console.WriteLine("Comments:");

                for (int x = 0; x < post.Comments.Count; x++)
                {
                    Console.WriteLine(post.Comments[x].Text);
                }
            Console.WriteLine("-----------------");
            }


        }
    }
}