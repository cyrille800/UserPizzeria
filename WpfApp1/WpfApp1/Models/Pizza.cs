﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    // classe imbriquée utilisé par ma classe pizza
    public class Ingredient
    {
        private String nom;
        private double quantite;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public double Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public Ingredient(String nom, double quantite)
        {
            this.nom = nom;
            this.quantite = quantite;
        }

    }

    // classe imbriquée utilisé par ma classe pizza
    public class PrixDetaille
    {
        private String nom;
        private double prix;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public PrixDetaille(String nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
        }

    }

    public class Pizza
    {
        protected String nom;
        protected List<Ingredient> ingrediant;
        protected String type;
        protected String image;
        protected List<PrixDetaille> prix;
        protected int id;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public List<PrixDetaille> Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public Pizza()
        {

        }
        public String Image
        {
            get { return image; }
            set { image = value; }
        }

        public List<Ingredient> Ingredient
        {
            get { return ingrediant; }
            set { ingrediant = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public Pizza(String nom, String type, int id)
        {
            ingrediant = new List<Ingredient>();
            this.nom = nom;
            this.prix = new List<PrixDetaille>();
            this.type = type;
            this.id = id;
        }

        public Pizza(String nom, String type, int id,String image, List<Ingredient> ingrediant, List<PrixDetaille> prix)
        {
            this.ingrediant = ingrediant;
            this.nom = nom;
            this.image = image;
            this.prix = prix;
            this.type = type;
            this.id = id;
        }

    }
}
