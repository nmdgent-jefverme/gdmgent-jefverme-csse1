using System;
using System.Collections.Generic;

namespace Opdracht08
{
    // 
    public interface IUitgave
    {
        void BuildHeader();
        
        void BuildMaininfo();
        
        void BuildAdvertisement();
    }
    
    public class Metro : IUitgave
    {
        private Content _content = new Content();

        public Metro()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._content = new Content();
        }
        

        public void BuildHeader()
        {
            this._content.Add("This is the title.");
            this._content.Add("This is the date.");
            this._content.Add("Editionnumber");
        }
        
        public void BuildMaininfo()
        {
            this._content.Add("This is some news.");
            this._content.Add("This is some news out of the country.");
        }
        
        public void BuildAdvertisement()
        {
            this._content.Add("This is an advertisement of HUBO.");
        }

        public Content GetContent()
        {
            Content result = this._content;

            this.Reset();

            return result;
        }
    }

    public class Nieuwsblad : IUitgave
    {
        private Content _content = new Content();

        public Nieuwsblad()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._content = new Content();
        }
        

        public void BuildHeader()
        {
            this._content.Add("This is the title.");
            this._content.Add("This is the date.");
            this._content.Add("Editionnumber");
        }
        
        public void BuildMaininfo()
        {
            this._content.Add("This is some news.");
            this._content.Add("This is some news of the weather.");
        }
        
        public void BuildAdvertisement()
        {
            this._content.Add("This is an advertisement of the Artevelde Hogeschool Mariakerke.");
        }

        public Content GetContent()
        {
            Content result = this._content;

            this.Reset();

            return result;
        }
    }
    
    public class Content
    {
        private List<object> _parts = new List<object>();
        
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
    
    public class Director
    {
        private IUitgave _builder;
        
        public IUitgave Builder
        {
            set { _builder = value; } 
        }

        public void buildMinimalViableProduct()
        {
            this._builder.BuildHeader();
        }
        
        public void buildFullFeaturedProduct()
        {
            this._builder.BuildHeader();
            this._builder.BuildMaininfo();
            this._builder.BuildAdvertisement();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // DE METRO
            var director = new Director();
            var builder = new Metro();
            director.Builder = builder;
            
            Console.WriteLine("Dit is het minimum van een pagina van METRO:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetContent().ListParts());

            Console.WriteLine("Een volledig gevulde pagina van METRO:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetContent().ListParts());

            // HET NIEUWSBLAD
            var director2 = new Director();
            var builder2 = new Nieuwsblad();
            director2.Builder = builder2;
            
            Console.WriteLine("Dit is het minimum van een pagina van NIEUWSBLAD:");
            director2.buildMinimalViableProduct();
            Console.WriteLine(builder2.GetContent().ListParts());

            Console.WriteLine("Een volledig gevulde pagina van NIEUWSBLAD:");
            director2.buildFullFeaturedProduct();
            Console.WriteLine(builder2.GetContent().ListParts());
        }
    }
}
