using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Playwright;

namespace BlazorTestingAZ.Tests.BlazeWright;

internal sealed class BlazorPage : IBlazorPage
{
    private readonly Func<Task> getCircuitUpTask;
    private readonly IPage page;

    public BlazorPage(Func<Task> getCircuitUpTask, IPage page)
    {
        this.getCircuitUpTask = getCircuitUpTask;
        this.page = page;
    }

    /// <summary>
    /// Gets a task that is completed when the Blazor Server SignalR connection has been established.
    /// </summary>
    public Task CircuitUp => getCircuitUpTask();

    [Obsolete]
    public IAccessibility Accessibility => page.Accessibility;

    public IBrowserContext Context => page.Context;

    public IReadOnlyList<IFrame> Frames => page.Frames;

    public bool IsClosed => page.IsClosed;

    public IKeyboard Keyboard => page.Keyboard;

    public IFrame MainFrame => page.MainFrame;

    public IMouse Mouse => page.Mouse;

    public IAPIRequestContext APIRequest => page.APIRequest;

    public ITouchscreen Touchscreen => page.Touchscreen;

    public string Url => page.Url;

    public IVideo? Video => page.Video;

    public PageViewportSizeResult? ViewportSize => page.ViewportSize;

    public IReadOnlyList<IWorker> Workers => page.Workers;

    public event EventHandler<IPage> Close
    {
        add
        {
            page.Close += value;
        }

        remove
        {
            page.Close -= value;
        }
    }

    public event EventHandler<IConsoleMessage> Console
    {
        add
        {
            page.Console += value;
        }

        remove
        {
            page.Console -= value;
        }
    }

    public event EventHandler<IPage> Crash
    {
        add
        {
            page.Crash += value;
        }

        remove
        {
            page.Crash -= value;
        }
    }

    public event EventHandler<IDialog> Dialog
    {
        add
        {
            page.Dialog += value;
        }

        remove
        {
            page.Dialog -= value;
        }
    }

    public event EventHandler<IPage> DOMContentLoaded
    {
        add
        {
            page.DOMContentLoaded += value;
        }

        remove
        {
            page.DOMContentLoaded -= value;
        }
    }

    public event EventHandler<IDownload> Download
    {
        add
        {
            page.Download += value;
        }

        remove
        {
            page.Download -= value;
        }
    }

    public event EventHandler<IFileChooser> FileChooser
    {
        add
        {
            page.FileChooser += value;
        }

        remove
        {
            page.FileChooser -= value;
        }
    }

    public event EventHandler<IFrame> FrameAttached
    {
        add
        {
            page.FrameAttached += value;
        }

        remove
        {
            page.FrameAttached -= value;
        }
    }

    public event EventHandler<IFrame> FrameDetached
    {
        add
        {
            page.FrameDetached += value;
        }

        remove
        {
            page.FrameDetached -= value;
        }
    }

    public event EventHandler<IFrame> FrameNavigated
    {
        add
        {
            page.FrameNavigated += value;
        }

        remove
        {
            page.FrameNavigated -= value;
        }
    }

    public event EventHandler<IPage> Load
    {
        add
        {
            page.Load += value;
        }

        remove
        {
            page.Load -= value;
        }
    }

    public event EventHandler<string> PageError
    {
        add
        {
            page.PageError += value;
        }

        remove
        {
            page.PageError -= value;
        }
    }

    public event EventHandler<IPage> Popup
    {
        add
        {
            page.Popup += value;
        }

        remove
        {
            page.Popup -= value;
        }
    }

    public event EventHandler<IRequest> Request
    {
        add
        {
            page.Request += value;
        }

        remove
        {
            page.Request -= value;
        }
    }

    public event EventHandler<IRequest> RequestFailed
    {
        add
        {
            page.RequestFailed += value;
        }

        remove
        {
            page.RequestFailed -= value;
        }
    }

    public event EventHandler<IRequest> RequestFinished
    {
        add
        {
            page.RequestFinished += value;
        }

        remove
        {
            page.RequestFinished -= value;
        }
    }

    public event EventHandler<IResponse> Response
    {
        add
        {
            page.Response += value;
        }

        remove
        {
            page.Response -= value;
        }
    }

    public event EventHandler<IWebSocket> WebSocket
    {
        add
        {
            page.WebSocket += value;
        }

        remove
        {
            page.WebSocket -= value;
        }
    }

    public event EventHandler<IWorker> Worker
    {
        add
        {
            page.Worker += value;
        }

        remove
        {
            page.Worker -= value;
        }
    }

    public Task AddInitScriptAsync(string? script = null, string? scriptPath = null)
    {
        return page.AddInitScriptAsync(script, scriptPath);
    }

    public Task<IElementHandle> AddScriptTagAsync(PageAddScriptTagOptions? options = null)
    {
        return page.AddScriptTagAsync(options);
    }

    public Task<IElementHandle> AddStyleTagAsync(PageAddStyleTagOptions? options = null)
    {
        return page.AddStyleTagAsync(options);
    }

    public Task BringToFrontAsync()
    {
        return page.BringToFrontAsync();
    }

    public Task CheckAsync(string selector, PageCheckOptions? options = null)
    {
        return page.CheckAsync(selector, options);
    }

    public Task ClickAsync(string selector, PageClickOptions? options = null)
    {
        return page.ClickAsync(selector, options);
    }

    public Task CloseAsync(PageCloseOptions? options = null)
    {
        return page.CloseAsync(options);
    }

    public Task<string> ContentAsync()
    {
        return page.ContentAsync();
    }

    public Task DblClickAsync(string selector, PageDblClickOptions? options = null)
    {
        return page.DblClickAsync(selector, options);
    }

    public Task DispatchEventAsync(string selector, string type, object? eventInit = null, PageDispatchEventOptions? options = null)
    {
        return page.DispatchEventAsync(selector, type, eventInit, options);
    }

    public Task DragAndDropAsync(string source, string target, PageDragAndDropOptions? options = null)
    {
        return page.DragAndDropAsync(source, target, options);
    }

    public Task EmulateMediaAsync(PageEmulateMediaOptions? options = null)
    {
        return page.EmulateMediaAsync(options);
    }

    public Task<T> EvalOnSelectorAllAsync<T>(string selector, string expression, object? arg = null)
    {
        return page.EvalOnSelectorAllAsync<T>(selector, expression, arg);
    }

    public Task<JsonElement?> EvalOnSelectorAllAsync(string selector, string expression, object? arg = null)
    {
        return page.EvalOnSelectorAllAsync(selector, expression, arg);
    }

    public Task<T> EvalOnSelectorAsync<T>(string selector, string expression, object? arg = null, PageEvalOnSelectorOptions? options = null)
    {
        return page.EvalOnSelectorAsync<T>(selector, expression, arg, options);
    }

    public Task<JsonElement?> EvalOnSelectorAsync(string selector, string expression, object? arg = null)
    {
        return page.EvalOnSelectorAsync(selector, expression, arg);
    }

    public Task<T> EvaluateAsync<T>(string expression, object? arg = null)
    {
        return page.EvaluateAsync<T>(expression, arg);
    }

    public Task<JsonElement?> EvaluateAsync(string expression, object? arg = null)
    {
        return page.EvaluateAsync(expression, arg);
    }

    public Task<IJSHandle> EvaluateHandleAsync(string expression, object? arg = null)
    {
        return page.EvaluateHandleAsync(expression, arg);
    }

    public Task ExposeBindingAsync(string name, Action callback, PageExposeBindingOptions? options = null)
    {
        return page.ExposeBindingAsync(name, callback, options);
    }

    public Task ExposeBindingAsync(string name, Action<BindingSource> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeBindingAsync<T>(string name, Action<BindingSource, T> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeBindingAsync<TResult>(string name, Func<BindingSource, TResult> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeBindingAsync<TResult>(string name, Func<BindingSource, IJSHandle, TResult> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeBindingAsync<T, TResult>(string name, Func<BindingSource, T, TResult> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeBindingAsync<T1, T2, TResult>(string name, Func<BindingSource, T1, T2, TResult> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeBindingAsync<T1, T2, T3, TResult>(string name, Func<BindingSource, T1, T2, T3, TResult> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeBindingAsync<T1, T2, T3, T4, TResult>(string name, Func<BindingSource, T1, T2, T3, T4, TResult> callback)
    {
        return page.ExposeBindingAsync(name, callback);
    }

    public Task ExposeFunctionAsync(string name, Action callback)
    {
        return page.ExposeFunctionAsync(name, callback);
    }

    public Task ExposeFunctionAsync<T>(string name, Action<T> callback)
    {
        return page.ExposeFunctionAsync(name, callback);
    }

    public Task ExposeFunctionAsync<TResult>(string name, Func<TResult> callback)
    {
        return page.ExposeFunctionAsync(name, callback);
    }

    public Task ExposeFunctionAsync<T, TResult>(string name, Func<T, TResult> callback)
    {
        return page.ExposeFunctionAsync(name, callback);
    }

    public Task ExposeFunctionAsync<T1, T2, TResult>(string name, Func<T1, T2, TResult> callback)
    {
        return page.ExposeFunctionAsync(name, callback);
    }

    public Task ExposeFunctionAsync<T1, T2, T3, TResult>(string name, Func<T1, T2, T3, TResult> callback)
    {
        return page.ExposeFunctionAsync(name, callback);
    }

    public Task ExposeFunctionAsync<T1, T2, T3, T4, TResult>(string name, Func<T1, T2, T3, T4, TResult> callback)
    {
        return page.ExposeFunctionAsync(name, callback);
    }

    public Task FillAsync(string selector, string value, PageFillOptions? options = null)
    {
        return page.FillAsync(selector, value, options);
    }

    public Task FocusAsync(string selector, PageFocusOptions? options = null)
    {
        return page.FocusAsync(selector, options);
    }

    public IFrame? Frame(string name)
    {
        return page.Frame(name);
    }

    public IFrame? FrameByUrl(string url)
    {
        return page.FrameByUrl(url);
    }

    public IFrame? FrameByUrl(Regex url)
    {
        return page.FrameByUrl(url);
    }

    public IFrame? FrameByUrl(Func<string, bool> url)
    {
        return page.FrameByUrl(url);
    }

    public IFrameLocator FrameLocator(string selector)
    {
        return page.FrameLocator(selector);
    }

    public Task<string?> GetAttributeAsync(string selector, string name, PageGetAttributeOptions? options = null)
    {
        return page.GetAttributeAsync(selector, name, options);
    }

    public ILocator GetByAltText(string text, PageGetByAltTextOptions? options = null)
    {
        return page.GetByAltText(text, options);
    }

    public ILocator GetByAltText(Regex text, PageGetByAltTextOptions? options = null)
    {
        return page.GetByAltText(text, options);
    }

    public ILocator GetByLabel(string text, PageGetByLabelOptions? options = null)
    {
        return page.GetByLabel(text, options);
    }

    public ILocator GetByLabel(Regex text, PageGetByLabelOptions? options = null)
    {
        return page.GetByLabel(text, options);
    }

    public ILocator GetByPlaceholder(string text, PageGetByPlaceholderOptions? options = null)
    {
        return page.GetByPlaceholder(text, options);
    }

    public ILocator GetByPlaceholder(Regex text, PageGetByPlaceholderOptions? options = null)
    {
        return page.GetByPlaceholder(text, options);
    }

    public ILocator GetByRole(AriaRole role, PageGetByRoleOptions? options = null)
    {
        return page.GetByRole(role, options);
    }

    public ILocator GetByTestId(string testId)
    {
        return page.GetByTestId(testId);
    }

    public ILocator GetByTestId(Regex testId)
    {
        return page.GetByTestId(testId);
    }

    public ILocator GetByText(string text, PageGetByTextOptions? options = null)
    {
        return page.GetByText(text, options);
    }

    public ILocator GetByText(Regex text, PageGetByTextOptions? options = null)
    {
        return page.GetByText(text, options);
    }

    public ILocator GetByTitle(string text, PageGetByTitleOptions? options = null)
    {
        return page.GetByTitle(text, options);
    }

    public ILocator GetByTitle(Regex text, PageGetByTitleOptions? options = null)
    {
        return page.GetByTitle(text, options);
    }

    public Task<IResponse?> GoBackAsync(PageGoBackOptions? options = null)
    {
        return page.GoBackAsync(options);
    }

    public Task<IResponse?> GoForwardAsync(PageGoForwardOptions? options = null)
    {
        return page.GoForwardAsync(options);
    }

    public async Task<IResponse?> GotoAsync(string url, PageGotoOptions? options = null)
    {
        var result = await page.GotoAsync(url, options);
        await CircuitUp;
        return result;
    }

    public Task HoverAsync(string selector, PageHoverOptions? options = null)
    {
        return page.HoverAsync(selector, options);
    }

    public Task<string> InnerHTMLAsync(string selector, PageInnerHTMLOptions? options = null)
    {
        return page.InnerHTMLAsync(selector, options);
    }

    public Task<string> InnerTextAsync(string selector, PageInnerTextOptions? options = null)
    {
        return page.InnerTextAsync(selector, options);
    }

    public Task<string> InputValueAsync(string selector, PageInputValueOptions? options = null)
    {
        return page.InputValueAsync(selector, options);
    }

    public Task<bool> IsCheckedAsync(string selector, PageIsCheckedOptions? options = null)
    {
        return page.IsCheckedAsync(selector, options);
    }

    public Task<bool> IsDisabledAsync(string selector, PageIsDisabledOptions? options = null)
    {
        return page.IsDisabledAsync(selector, options);
    }

    public Task<bool> IsEditableAsync(string selector, PageIsEditableOptions? options = null)
    {
        return page.IsEditableAsync(selector, options);
    }

    public Task<bool> IsEnabledAsync(string selector, PageIsEnabledOptions? options = null)
    {
        return page.IsEnabledAsync(selector, options);
    }

    public Task<bool> IsHiddenAsync(string selector, PageIsHiddenOptions? options = null)
    {
        return page.IsHiddenAsync(selector, options);
    }

    public Task<bool> IsVisibleAsync(string selector, PageIsVisibleOptions? options = null)
    {
        return page.IsVisibleAsync(selector, options);
    }

    public ILocator Locator(string selector, PageLocatorOptions? options = null)
    {
        return page.Locator(selector, options);
    }

    public Task<IPage?> OpenerAsync()
    {
        return page.OpenerAsync();
    }

    public Task PauseAsync()
    {
        return page.PauseAsync();
    }

    public Task<byte[]> PdfAsync(PagePdfOptions? options = null)
    {
        return page.PdfAsync(options);
    }

    public Task PressAsync(string selector, string key, PagePressOptions? options = null)
    {
        return page.PressAsync(selector, key, options);
    }

    public Task<IReadOnlyList<IElementHandle>> QuerySelectorAllAsync(string selector)
    {
        return page.QuerySelectorAllAsync(selector);
    }

    public Task<IElementHandle?> QuerySelectorAsync(string selector, PageQuerySelectorOptions? options = null)
    {
        return page.QuerySelectorAsync(selector, options);
    }

    public Task<IResponse?> ReloadAsync(PageReloadOptions? options = null)
    {
        return page.ReloadAsync(options);
    }

    public Task RouteAsync(string url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        return page.RouteAsync(url, handler, options);
    }

    public Task RouteAsync(Regex url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        return page.RouteAsync(url, handler, options);
    }

    public Task RouteAsync(Func<string, bool> url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        return page.RouteAsync(url, handler, options);
    }

    public Task RouteAsync(string url, Func<IRoute, Task> handler, PageRouteOptions? options = null)
    {
        return page.RouteAsync(url, handler, options);
    }

    public Task RouteAsync(Regex url, Func<IRoute, Task> handler, PageRouteOptions? options = null)
    {
        return page.RouteAsync(url, handler, options);
    }

    public Task RouteAsync(Func<string, bool> url, Func<IRoute, Task> handler, PageRouteOptions? options = null)
    {
        return page.RouteAsync(url, handler, options);
    }

    public Task RouteFromHARAsync(string har, PageRouteFromHAROptions? options = null)
    {
        return page.RouteFromHARAsync(har, options);
    }

    public Task<IConsoleMessage> RunAndWaitForConsoleMessageAsync(Func<Task> action, PageRunAndWaitForConsoleMessageOptions? options = null)
    {
        return page.RunAndWaitForConsoleMessageAsync(action, options);
    }

    public Task<IDownload> RunAndWaitForDownloadAsync(Func<Task> action, PageRunAndWaitForDownloadOptions? options = null)
    {
        return page.RunAndWaitForDownloadAsync(action, options);
    }

    public Task<IFileChooser> RunAndWaitForFileChooserAsync(Func<Task> action, PageRunAndWaitForFileChooserOptions? options = null)
    {
        return page.RunAndWaitForFileChooserAsync(action, options);
    }

    [Obsolete]
    public Task<IResponse?> RunAndWaitForNavigationAsync(Func<Task> action, PageRunAndWaitForNavigationOptions? options = null)
    {
        return page.RunAndWaitForNavigationAsync(action, options);
    }

    public Task<IPage> RunAndWaitForPopupAsync(Func<Task> action, PageRunAndWaitForPopupOptions? options = null)
    {
        return page.RunAndWaitForPopupAsync(action, options);
    }

    public Task<IRequest> RunAndWaitForRequestAsync(Func<Task> action, string urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequestAsync(action, urlOrPredicate, options);
    }

    public Task<IRequest> RunAndWaitForRequestAsync(Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequestAsync(action, urlOrPredicate, options);
    }

    public Task<IRequest> RunAndWaitForRequestAsync(Func<Task> action, Func<IRequest, bool> urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequestAsync(action, urlOrPredicate, options);
    }

    public Task<IRequest> RunAndWaitForRequestFinishedAsync(Func<Task> action, PageRunAndWaitForRequestFinishedOptions? options = null)
    {
        return page.RunAndWaitForRequestFinishedAsync(action, options);
    }

    public Task<IResponse> RunAndWaitForResponseAsync(Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponseAsync(action, urlOrPredicate, options);
    }

    public Task<IResponse> RunAndWaitForResponseAsync(Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponseAsync(action, urlOrPredicate, options);
    }

    public Task<IResponse> RunAndWaitForResponseAsync(Func<Task> action, Func<IResponse, bool> urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponseAsync(action, urlOrPredicate, options);
    }

    public Task<IWebSocket> RunAndWaitForWebSocketAsync(Func<Task> action, PageRunAndWaitForWebSocketOptions? options = null)
    {
        return page.RunAndWaitForWebSocketAsync(action, options);
    }

    public Task<IWorker> RunAndWaitForWorkerAsync(Func<Task> action, PageRunAndWaitForWorkerOptions? options = null)
    {
        return page.RunAndWaitForWorkerAsync(action, options);
    }

    public Task<byte[]> ScreenshotAsync(PageScreenshotOptions? options = null)
    {
        return page.ScreenshotAsync(options);
    }

    public Task<IReadOnlyList<string>> SelectOptionAsync(string selector, string values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options);
    }

    public Task<IReadOnlyList<string>> SelectOptionAsync(string selector, IElementHandle values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options);
    }

    public Task<IReadOnlyList<string>> SelectOptionAsync(string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options);
    }

    public Task<IReadOnlyList<string>> SelectOptionAsync(string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options);
    }

    public Task<IReadOnlyList<string>> SelectOptionAsync(string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options);
    }

    public Task<IReadOnlyList<string>> SelectOptionAsync(string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options);
    }

    public Task SetCheckedAsync(string selector, bool checkedState, PageSetCheckedOptions? options = null)
    {
        return page.SetCheckedAsync(selector, checkedState, options);
    }

    public Task SetContentAsync(string html, PageSetContentOptions? options = null)
    {
        return page.SetContentAsync(html, options);
    }

    public void SetDefaultNavigationTimeout(float timeout)
    {
        page.SetDefaultNavigationTimeout(timeout);
    }

    public void SetDefaultTimeout(float timeout)
    {
        page.SetDefaultTimeout(timeout);
    }

    public Task SetExtraHTTPHeadersAsync(IEnumerable<KeyValuePair<string, string>> headers)
    {
        return page.SetExtraHTTPHeadersAsync(headers);
    }

    public Task SetInputFilesAsync(string selector, string files, PageSetInputFilesOptions? options = null)
    {
        return page.SetInputFilesAsync(selector, files, options);
    }

    public Task SetInputFilesAsync(string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
    {
        return page.SetInputFilesAsync(selector, files, options);
    }

    public Task SetInputFilesAsync(string selector, FilePayload files, PageSetInputFilesOptions? options = null)
    {
        return page.SetInputFilesAsync(selector, files, options);
    }

    public Task SetInputFilesAsync(string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
    {
        return page.SetInputFilesAsync(selector, files, options);
    }

    public Task SetViewportSizeAsync(int width, int height)
    {
        return page.SetViewportSizeAsync(width, height);
    }

    public Task TapAsync(string selector, PageTapOptions? options = null)
    {
        return page.TapAsync(selector, options);
    }

    public Task<string?> TextContentAsync(string selector, PageTextContentOptions? options = null)
    {
        return page.TextContentAsync(selector, options);
    }

    public Task<string> TitleAsync()
    {
        return page.TitleAsync();
    }

    [Obsolete]
    public Task TypeAsync(string selector, string text, PageTypeOptions? options = null)
    {
        return page.TypeAsync(selector, text, options);
    }

    public Task UncheckAsync(string selector, PageUncheckOptions? options = null)
    {
        return page.UncheckAsync(selector, options);
    }

    public Task UnrouteAsync(string url, Action<IRoute>? handler = null)
    {
        return page.UnrouteAsync(url, handler);
    }

    public Task UnrouteAsync(Regex url, Action<IRoute>? handler = null)
    {
        return page.UnrouteAsync(url, handler);
    }

    public Task UnrouteAsync(Func<string, bool> url, Action<IRoute>? handler = null)
    {
        return page.UnrouteAsync(url, handler);
    }

    public Task UnrouteAsync(string url, Func<IRoute, Task> handler)
    {
        return page.UnrouteAsync(url, handler);
    }

    public Task UnrouteAsync(Regex url, Func<IRoute, Task> handler)
    {
        return page.UnrouteAsync(url, handler);
    }

    public Task UnrouteAsync(Func<string, bool> url, Func<IRoute, Task> handler)
    {
        return page.UnrouteAsync(url, handler);
    }

    public Task<IConsoleMessage> WaitForConsoleMessageAsync(PageWaitForConsoleMessageOptions? options = null)
    {
        return page.WaitForConsoleMessageAsync(options);
    }

    public Task<IDownload> WaitForDownloadAsync(PageWaitForDownloadOptions? options = null)
    {
        return page.WaitForDownloadAsync(options);
    }

    public Task<IFileChooser> WaitForFileChooserAsync(PageWaitForFileChooserOptions? options = null)
    {
        return page.WaitForFileChooserAsync(options);
    }

    public Task<IJSHandle> WaitForFunctionAsync(string expression, object? arg = null, PageWaitForFunctionOptions? options = null)
    {
        return page.WaitForFunctionAsync(expression, arg, options);
    }

    public Task WaitForLoadStateAsync(LoadState? state = null, PageWaitForLoadStateOptions? options = null)
    {
        return page.WaitForLoadStateAsync(state, options);
    }

    [Obsolete]
    public Task<IResponse?> WaitForNavigationAsync(PageWaitForNavigationOptions? options = null)
    {
        return page.WaitForNavigationAsync(options);
    }

    public Task<IPage> WaitForPopupAsync(PageWaitForPopupOptions? options = null)
    {
        return page.WaitForPopupAsync(options);
    }

    public Task<IRequest> WaitForRequestAsync(string urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequestAsync(urlOrPredicate, options);
    }

    public Task<IRequest> WaitForRequestAsync(Regex urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequestAsync(urlOrPredicate, options);
    }

    public Task<IRequest> WaitForRequestAsync(Func<IRequest, bool> urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequestAsync(urlOrPredicate, options);
    }

    public Task<IRequest> WaitForRequestFinishedAsync(PageWaitForRequestFinishedOptions? options = null)
    {
        return page.WaitForRequestFinishedAsync(options);
    }

    public Task<IResponse> WaitForResponseAsync(string urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponseAsync(urlOrPredicate, options);
    }

    public Task<IResponse> WaitForResponseAsync(Regex urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponseAsync(urlOrPredicate, options);
    }

    public Task<IResponse> WaitForResponseAsync(Func<IResponse, bool> urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponseAsync(urlOrPredicate, options);
    }

    public Task<IElementHandle?> WaitForSelectorAsync(string selector, PageWaitForSelectorOptions? options = null)
    {
        return page.WaitForSelectorAsync(selector, options);
    }

    public Task WaitForTimeoutAsync(float timeout)
    {
        return page.WaitForTimeoutAsync(timeout);
    }

    public Task WaitForURLAsync(string url, PageWaitForURLOptions? options = null)
    {
        return page.WaitForURLAsync(url, options);
    }

    public Task WaitForURLAsync(Regex url, PageWaitForURLOptions? options = null)
    {
        return page.WaitForURLAsync(url, options);
    }

    public Task WaitForURLAsync(Func<string, bool> url, PageWaitForURLOptions? options = null)
    {
        return page.WaitForURLAsync(url, options);
    }

    public Task<IWebSocket> WaitForWebSocketAsync(PageWaitForWebSocketOptions? options = null)
    {
        return page.WaitForWebSocketAsync(options);
    }

    public Task<IWorker> WaitForWorkerAsync(PageWaitForWorkerOptions? options = null)
    {
        return page.WaitForWorkerAsync(options);
    }
}
