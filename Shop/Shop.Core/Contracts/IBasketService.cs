using Shop.Core.View_Model;
using System.Collections.Generic;
using System.Web;

namespace Shop.Core.Contracts
{
    public interface IBasketService
    {
        void AddBasket(HttpContextBase httpContext, string productId);
        List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
        void RemoveFromBasket(HttpContextBase httpContext, string itemId);
    }
}