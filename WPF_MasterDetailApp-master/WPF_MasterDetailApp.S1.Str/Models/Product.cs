using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS

        public enum GuitarType { Electric, Acoustic, ElectricAcoutic }

        #endregion

        #region FIELDS

        private int _id;
        private string _guitar;
        private string _manufacturer;
        private int _manufactureyear;
        private GuitarType _guitartype;
        private string _imageFileName;
        private string _description;
        private DateTime _hireDate;
        private double _averageAnnualGross;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Guitar
        {
            get { return _guitar; }
            set
            {
                _guitar = value;
                
            }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                _manufacturer = value;
                
            }
        }

        public int ManufactureYear
        {
            get { return _manufactureyear; }
            set { _manufactureyear = value; }
        }

        public GuitarType guitarType
        {
            get { return _guitartype; }
            set { _guitartype = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public double AverageAnnualGross
        {
            get { return _averageAnnualGross; }
            set { _averageAnnualGross = value; }
        }

        public string FullName
        {
            get { return _guitar + " " + _manufacturer; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
