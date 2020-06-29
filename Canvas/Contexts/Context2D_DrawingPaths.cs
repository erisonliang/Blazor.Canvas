﻿using Excubo.Blazor.Canvas.Extensions;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Fills the current sub-paths with the current fill style.
        /// </summary>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask FillAsync(FillRule fill_rule) => SetAsync("fill", fill_rule);
        /// <summary>
        /// Fills the current sub-paths with the current fill style.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fill_rule"></param>
        private void FillAsync(object path, FillRule fill_rule)
        {
            // TODO
        }
        /// <summary>
        /// Strokes the current sub-paths with the current stroke style.
        /// </summary>
        /// <returns></returns>
        public ValueTask StrokeAsync() => InvokeAsync("stroke");
        /// <summary>
        /// Strokes the current sub-paths with the current stroke style.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private void StrokeAsync(object path)
        {
            // TODO
        }
        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="element"></param>
        private void drawFocusIfNeeded(object element)
        {
            // TODO
        }
        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="element"></param>
        private void drawFocusIfNeeded(object path, object element)
        {
            // TODO
        }
        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.")]
        /// </summary>
        private void scrillPathIntoView()
        {
            // TODO
        }
        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.")]
        private void scrillPathIntoView(object path)
        {
            // TODO
        }
        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is called appears inside the clipping path only. For an example, see Clipping paths in the Canvas tutorial.
        /// </summary>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask ClipAsync(FillRule fill_rule) => SetAsync("clip", fill_rule);
        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is called appears inside the clipping path only. For an example, see Clipping paths in the Canvas tutorial.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fill_rule"></param>
        private void clip(object path, FillRule fill_rule)
        {
            //TODO
        }
        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask<bool> IsPointInPathAsync(double x, double y, FillRule fill_rule) => InvokeAsync<bool>("isPointInPath", x, y, fill_rule.ToJsEnumValue());
        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="fill_rule"></param>
        private void isPointInPath(object path, double x, double y, FillRule fill_rule)
        {
            //TODO
        }
        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask<bool> IsPointInStrokeAsync(double x, double y) => InvokeAsync<bool>("isPointInStroke", x, y);
        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void isPointInStroke(object path, double x, double y)
        {
            //TODO
        }
    }
}