using System.Linq.Expressions;

namespace poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creacion de nuestros gameobjects (boton derecho -> create empty)
            GameObject go1 = new GameObject();
            GameObject go2 = new GameObject();

            // creacion y asignacion de nuevos componentes
            SpriteRenderer spriteRenderer1 = new SpriteRenderer();
            go1.AddComponent(spriteRenderer1);
            spriteRenderer1.color = ConsoleColor.Magenta;
            spriteRenderer1.sprite = 'Z';
            SpriteRenderer spriteRenderer2 = new SpriteRenderer();
            spriteRenderer2.color = ConsoleColor.Yellow;
            spriteRenderer2.sprite = 'A';
            go2.AddComponent(spriteRenderer2);

            ScreamOnInput screamOnInput = new ScreamOnInput();
            go2.AddComponent(screamOnInput);

            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(go1);
            gameObjects.Add(go2);

            // inicio escena
            foreach(GameObject go in gameObjects)
            {
                go.Start();
            }

            bool exit = false;
            while(!exit)
            {
                Console.Clear();
                foreach(GameObject go in gameObjects)
                {
                    go.Update();
                }

                char c = (char)Console.Read();
                if(c == 'X')
                {
                    exit = true;
                }
            }



        }
    }
}