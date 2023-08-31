using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Música_aa
{
    class Program
    {
        static void Main(string[] args)
        {
            Artista MotherMother = new Artista();
            MotherMother.Nombre = "MotherMother";
            MotherMother.Miembros = "Ryan Guldemond, Molly Guldemond, Ali Siadat, Jasmin Parkin, Mike Young";
            MotherMother.GeneroMusical = "Rock indie";
            MotherMother.Albumes = "Touch up, O my heart, Eureka, The sticks, Very good bad thing, No culture"
                +"Dance and cry, Inside";
            MotherMother.AnioDeInicio = 2005;
            MotherMother.EstadoActual = "Activo";


            Album Eureka = new Album();
            Eureka.Nombre = "Eureka";
            Eureka.AnioDePublicacion = 2011;
            Eureka.Generos = "Indie Rock";
            Eureka.Duracion = 42.55f;
            Eureka.NumDeCanciones = 12;
            Eureka.DisenioPortada = "León de colores rugiendo";

            Cancion SimplySimple = new Cancion();
            SimplySimple.Nombre = "Simply simple";
            SimplySimple.Album = "Eureka"
            SimplySimple.Duracion = 3.33f;
            SimplySimple.Genero = "Rock indie";
            SimplySimple.Numerodepista = 6;
            SimplySimple.AnioDePublicacion = 2011;
            SimplySimple.Autor = "Jeremy Page, Ryan Guldemond";


            Artista TOP = new Artista();
            TOP.Nombre = "Twenty One Pilots";
            TOP.Miembros = "Tyler Joseph, Josh Dun";
            TOP.GeneroMusical = " Rock, Hip hop, Pop, Rock alternativo, Indie pop";
            TOP.Albumes = "Blurryface, Trench";
            TOP.AnioDeInicio = 2010;
            TOP.EstadoActual = "En pausa";

            Album Blurryface = new Album();
            Blurryface.Nombre = "Blurryface";
            Blurryface.AnioDePublicacion = 2015;
            Blurryface.Generos = "Rock, Hip hop, Pop, Rock alternativo, Indie pop";
            Blurryface.Duracion = 52.23f;
            Blurryface.NumDeCanciones = 14;
            Blurryface.DisenioPortada = "Círculos rojos, negros y blancos con animal print";

            Cancion Message = new Cancion();
            Message.Nombre = "Message Man";
            Message.Album = "Blurryface";
            Message.Duracion = 4.01f;
            Message.Genero = " Reggae, Alternativa/independiente, Pop";
            Message.Numerodepista = 10;
            Message.AnioDePublicacion = 2015;
            Message.Autor = "Tyler Joseph";

            Artista Jack = new Artista();
            Jack.Nombre = "Jack Stauber";
            Jack.Miembros = "Jack Stauber";
            Jack.GeneroMusical = "Pop";
            Jack.AnioDeInicio = 2007;
            Jack.EstadoActual = "Activo";

            Album Food = new Album();
            Food.Nombre = "Pop Food";
            Food.AnioDePublicacion = 2017;
            Food.Generos = "Alternativa/independiente, Pop";
            Food.Duracion = 36.16f;
            Food.NumDeCanciones = 13;
            Food.DisenioPortada = "Un teclado con comida";

            Cancion oh = new Cancion();
            oh.Nombre = "Oh Lahoma";
            oh.Album = "Pop Food";
            oh.Duracion = 3.06f;
            oh.Genero = "Pop psicodélico, Pop";
            oh.Numerodepista = 2;
            oh.AnioDePublicacion = 2017;
            oh.Autor = "Jack Stauber";

            //dkadsj

        }
    }
}
