﻿using Microsoft.Playwright;

namespace BlazeWright;

public static class BlazorPageExtensions
{
    public static Task<IResponse?> GotoPreRenderedAsync(this IPage page, string url)
        => page.GotoAsync(url, new() { WaitUntil = WaitUntilState.NetworkIdle });
}