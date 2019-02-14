using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter __productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            __productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(__productWindowPresenter);
            _productWindowView.DataContext = __productWindowPresenter;
            _productWindowView.Show();
        }

        private Product GetProductData()
        {
            return new Product()
            {
                Id = 1,
                Guitar = "Stratocaster", 
                Manufacturer = "Fender",
                ManufactureYear = 1954,
                guitarType = Product.GuitarType.Electric,
                AverageAnnualGross = 33333,
                HireDate = DateTime.Parse("1/22/1958"),
                Description = "",
                ImageFileName = "fenderstartvertical.jpg"


        };
        }

        private Company GetCompanyData()
        {
            Company company = new Company
            {
                Name = "RH industries",
                Address = "Crystal Lake",
                City = "Beulah"
            };

            return company;
        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
