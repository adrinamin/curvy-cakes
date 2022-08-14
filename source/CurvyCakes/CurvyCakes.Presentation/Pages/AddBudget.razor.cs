
using CurvyCakes.Presentation.Data;

using Microsoft.AspNetCore.Components;

namespace CurvyCakes.Presentation.Pages
{
    public partial class AddBudget : ComponentBase
    {
        private readonly BudgetDto budget = new();
        private AccountDto account = new();
        private string alertVisibility = "d-none";

        [Parameter]
        public Guid AccountId { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            account = AccountService.GetById(AccountId);
            budget.Account = account;
        }

        private void OnValidSubmit()
        {
            try
            {
                ArgumentNullException.ThrowIfNull(budget, nameof(budget));
                this.BudgetService.Add(budget);
                NavigationManager.NavigateTo($"/account/{account.Id}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                alertVisibility = "d-block";
            }

            StateHasChanged();
        }
    }
}
