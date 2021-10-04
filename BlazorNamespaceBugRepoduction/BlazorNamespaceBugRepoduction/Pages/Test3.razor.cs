using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using FreshWithoutSWordLibrary.SomeFolder;

namespace BlazorNamespaceBugRepoduction.Pages
{
    public partial class Test3 : IAsyncDisposable
    {
        [Inject]
        protected HttpClient Http { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        public MyTestClass3 MyProperty { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            var sth1 = new FreshWithoutSWordLibrary.SomeFolder.MyTestClass3();
            var sth2 = MyTestEnum3.One;
            var sth3 = new MyTestClass3();

            MyProperty = new MyTestClass3();
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
