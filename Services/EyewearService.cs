using SeeSharpEyewear.Models;
using System.Collections.Generic;
using System.Linq;

namespace SeeSharpEyewear.Services
{
    public static class EyewearService
    {
        static List<Eyewear> Eyewears { get; }
        static int nextId = 3;
        static EyewearService()
        {
            Eyewears = new List<Eyewear>
            {
                new Eyewear { Id = 1, Name = "Ray-Ban Clubmaster", Color = "Brown / Gold", Shape = "Browline" },
                new Eyewear { Id = 2, Name = "Ottoto Bellona", Color = "Pink / Gold", Shape = "Oval" },
                new Eyewear { Id = 3, Name = "Oakley Socket 5.5", Color = "Gunmetal", Shape = "Rectangle" }
            };
        }

        public static List<Eyewear> GetAll() => Eyewears;

        public static Eyewear Get(int id) => Eyewears.FirstOrDefault(p => p.Id == id);

        public static void Add(Eyewear Eyewear)
        {
            Eyewear.Id = nextId++;
            Eyewears.Add(Eyewear);
        }

        public static void Delete(int id)
        {
            var Eyewear = Get(id);
            if(Eyewear is null)
                return;

            Eyewears.Remove(Eyewear);
        }

        public static void Update(Eyewear Eyewear)
        {
            var index = Eyewears.FindIndex(p => p.Id == Eyewear.Id);
            if(index == -1)
                return;

            Eyewears[index] = Eyewear;
        }
    }
}