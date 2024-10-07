using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagelec.Entities
{
    public class Product : AbstractEntity
    {
        private readonly int _id;
        private string _designation;
        private string _description;
        private readonly Date _createdAt;
        private int _stock;
        private double _price;
        private string _imageFilePath;


        public int getId() { return this._id; }
        public Product setId(int id)
        {
            this._id = id;
            return this;
        }

        public string getDesignation() { return this._designation; }
        public Product setDesignation(string designation)
        {
            this._designation = designation;
            return this;
        }

        public string getDescription() { return this._description; }
        public Product setDescription(string description)
        {
            this._description = description;
            return this;
        }

        public Date getCreatedAt() { return this._createdAt; }
        
        public int getStock() { return this._stock; }
        public Product setStock(int stock)
        {
            this._stock = stock;
            return this;
        }

        public double getPrice() { return this._price; }
        public Product setPrice(double price)
        {
            this._price = price;
            return this;
        }

        public string getImageFilePath() { return this._imageFilePath; }
        public Product setImageFilePath(string imageFilePath)
        {
            this._imagedFilePath = imageFilePath;
            return this;
        }
    }
}