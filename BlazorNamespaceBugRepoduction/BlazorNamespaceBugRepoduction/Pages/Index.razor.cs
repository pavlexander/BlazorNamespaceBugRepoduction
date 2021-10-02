using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Shared.Responses;

namespace BlazorNamespaceBugRepoduction.Pages
{
    public partial class Index : IAsyncDisposable
    {
        [Inject]
        protected HttpClient Http { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        public MyTestClass MyProperty { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            var sth1 = new Shared.Responses.MyTestClass(); // error here
            var sth2 = MyTestEnum.One; // OK
            var sth3 = new MyTestClass();  // OK

            MyProperty = new MyTestClass();  // OK
        }

        protected override async Task OnParametersSetAsync()
        {
            //
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //
        }

        public async ValueTask DisposeAsync()
        {
            //
        }
    }
}
