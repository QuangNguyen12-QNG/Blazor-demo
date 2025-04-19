using ClothingStore.Models;
using System.Collections.Generic;

namespace ClothingStore.Services
{
    public class CartService
    {
        private List<Product> _cart = new List<Product>();

        public void AddToCart(Product product)
        {
            _cart.Add(product);
        }
        public void ClearCart()
        {
            _cart.Clear();
        }
        public List<Product> GetCartItems()
        {
            return _cart;
        }

        public void RemoveFromCart(Product product)
        {
            var itemToRemove = _cart.FirstOrDefault(p => p.Id == product.Id);
            if (itemToRemove != null)
            {
                _cart.Remove(itemToRemove);
            }
        }
    }
}

