using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class GameObject
    {
        private List<Component> components;

        public GameObject()
        {
            components = new List<Component>();
        }

        public void AddComponent(Component c)
        {
            components.Add(c);
        }

        public void Start()
        {
            foreach(Component c in components)
            {
                c.Start();
            }
        }

        public void Update()
        {
            foreach (Component c in components)
            {
                c.Update();
            }
        }

        // getcomponent ??
    }
}
