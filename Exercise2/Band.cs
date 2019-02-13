﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public abstract class Band : IComparable
    {
        //props
        public string Name { get; set; }
        public int Formed { get; set; }
        public string Members { get; set; }
        public Album[] Albums { get; set; }
        public string BandImage { get; set; }

        //ctors

        //methods
        public override string ToString()
        {
            //return (this.Name);
            return string.Format($"{Name} - {this.GetType().Name}");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Band otherBand = obj as Band;
            if (otherBand != null)
                return this.Name.CompareTo(otherBand.Name);
            else
                throw new ArgumentException("Object is not a Band");
        }
    }
    public class RockBand : Band
    {
        public RockBand()
        {
            Albums = new Album[10];
        }
        //public override string ToString()
        //{
        //    return (this.Name + " - Rock");
        //}
    }

    public class PopBand : Band
    {
        public PopBand()
        {
            Albums = new Album[10];
        }

        //public override string ToString()
        //{
        //    return (this.Name + " - Pop");
        //}
    }

    public class IndieBand : Band
    {
        public IndieBand()
        {
            Albums = new Album[10];
        }
        //public override string ToString()
        //{
        //    return (this.Name + " - Indie");
        //}
    }
}
