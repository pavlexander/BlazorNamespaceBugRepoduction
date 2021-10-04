using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorNamespaceBugRepoduction.TestNs;

namespace BlazorNamespaceBugRepoduction.Pages
{
    public partial class Test2 : IAsyncDisposable
    {
        [Inject]
        protected HttpClient Http { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        public MyTestClass2 MyProperty { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            var sth1 = new BlazorNamespaceBugRepoduction.TestNs.MyTestClass2();
            var sth2 = MyTestEnum2.One;
            var sth3 = new MyTestClass2();

            MyProperty = new MyTestClass2();
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
