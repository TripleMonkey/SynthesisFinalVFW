// Nigel Krajewski
// MDV1830-O C202007 01
// Synthesis - FINAL

using System;

namespace NigelKrajewski_Final
{
    class DataItem
    {
        string _title;
        string _category;
        string _publisher;
        decimal _price;
        int _imageIndex;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }

        // ToString override for lvi text
        public override string ToString()
        {
            return Title + "\n" + Category;
        }
    }
}
