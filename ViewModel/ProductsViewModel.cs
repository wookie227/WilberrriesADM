using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WilberrriesADM.Data;
using WilberrriesADM.Models;
using WilberrriesADM.View;

namespace WilberrriesADM.ViewModel
{
    public class ProductsViewModel : ViewModelBase
    {
        private ObservableCollection<Product> _allProducts;
        public Product SelectedProduct { get; set; }
        public ICommand OpenEditItemWnd { get; }
        public ICommand DeleteItem { get; }



        public ObservableCollection<Product> AllProducts
        {
            get { return _allProducts; }
            set
            {
                _allProducts = value;
                OnPropertyChanged(nameof(AllProducts));
            }
        }

        public ProductsViewModel()
        {
            using var context = new DataBase();
            AllProducts = new ObservableCollection<Product>(context.Products.ToList());
            OpenEditItemWnd = new RelayCommand(EditItem);
            DeleteItem = new RelayCommand(DeleteSelectedItem);
        }
        private void DeleteSelectedItem(object obj)
        {
            if (obj is Product product)
            {
                // Удаляем выбранный товар из списка товаров
                AllProducts.Remove(product);
                // Дополнительно, возможно, вам нужно удалить товар из источника данных.
            }
        }
        private void EditItem(object obj)
        {
                // Создаем экземпляр окна редактирования товара, передаем выбранный товар в конструктор
                EditQuantityProduct editWindow = new EditQuantityProduct(SelectedProduct);
                // Открываем окно
                editWindow.Show();
                // Обновляем список товаров (если необходимо)
        }
    }
}
