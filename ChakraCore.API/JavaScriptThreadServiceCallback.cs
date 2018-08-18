﻿using System;

namespace ChakraCore.API {
  /// <summary>
  ///     A thread service callback.
  /// </summary>
  /// <remarks>
  ///     The host can specify a background thread service when calling <c>JsCreateRuntime</c>. If
  ///     specified, then background work items will be passed to the host using this callback. The
  ///     host is expected to either begin executing the background work item immediately and return
  ///     true or return false and the runtime will handle the work item in-thread.
  /// </remarks>
  /// <param name="callback">The callback for the background work item.</param>
  /// <param name="callbackState">The data argument to be passed to the callback.</param>
  public delegate bool JavaScriptThreadServiceCallback(
    JavaScriptBackgroundWorkItemCallback callbackFunction,
    IntPtr callbackData
  );
}
