/*
 * MIT License
 * 
 * Copyright (c) 2009-2021 Jingwood, unvell.com. All right reserved.
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshallingAttribute]

namespace unvell.D2DLib
{
	internal static partial class D2D
	{

#if DEBUG

#if X86
		const string DLL_NAME = "d2dlib32d.dll";
#elif X64
		const string DLL_NAME = "d2dlib64d.dll";
#endif

#else // Release

#if X86
		const string DLL_NAME = "d2dlib32.dll";
#elif X64
		const string DLL_NAME = "d2dlib64.dll";
#endif

#endif

		#region Device Context

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE GetLastResult();

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateContext(HANDLE hwnd);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DestroyContext(HANDLE context);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void SetContextProperties(HANDLE context, D2DAntialiasMode antialiasMode = D2DAntialiasMode.PerPrimitive);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE BeginRender(HANDLE context);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE BeginRenderWithBackgroundColor(HANDLE context, D2DColor backColor);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE BeginRenderWithBackgroundBitmap(HANDLE context, HANDLE bitmap);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void EndRender(HANDLE context);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void Flush(HANDLE context);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void Clear(HANDLE context, D2DColor color);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateBitmapRenderTarget(HANDLE context, D2DSize size);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawBitmapRenderTarget(HANDLE context, HANDLE bitmapRenderTarget, ref D2DRect rect,
			FLOAT opacity = 1, D2DBitmapInterpolationMode interpolationMode = D2DBitmapInterpolationMode.Linear);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE GetBitmapRenderTargetBitmap(HANDLE bitmapRenderTarget);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DestroyBitmapRenderTarget(HANDLE context);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE ResizeContext(HANDLE context);


		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE GetDPI(HANDLE context, out FLOAT dpix, out FLOAT dpiy);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE SetDPI(HANDLE context, FLOAT dpix, FLOAT dpiy);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void PushClip(HANDLE context, in D2DRect rect, D2DAntialiasMode antiAliasMode = D2DAntialiasMode.PerPrimitive);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void PopClip(HANDLE context);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateLayer(HANDLE ctx);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE PushLayer(HANDLE ctx, HANDLE layerHandle, D2DRect contentBounds, [Optional] in HANDLE geometryHandle, [ Optional] HANDLE opacityBrush, LayerOptions layerOptions = LayerOptions.InitializeForClearType);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void PopLayer(HANDLE ctx);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void PushTransform(HANDLE context);
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void PopTransform(HANDLE context);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void RotateTransform(HANDLE context,FLOAT angle);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void RotateTransform(HANDLE context,FLOAT angle,D2DPoint center);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void TranslateTransform(HANDLE context,FLOAT x,FLOAT y);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void ScaleTransform(HANDLE context,FLOAT sx,FLOAT sy, [Optional] D2DPoint center);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void SkewTransform(HANDLE ctx,FLOAT angleX,FLOAT angleY, [Optional] D2DPoint center);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void SetTransform(HANDLE context,ref Matrix3x2 mat);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void GetTransform(HANDLE context, out Matrix3x2 mat);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void ResetTransform(HANDLE context);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void ReleaseObject(HANDLE objectHandle);

		#endregion // Device Context

		#region Simple Sharp

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawLine(HANDLE context, D2DPoint start, D2DPoint end, D2DColor color,
			FLOAT weight = 1, D2DDashStyle dashStyle = D2DDashStyle.Solid,
			D2DCapStyle startCap = D2DCapStyle.Flat, D2DCapStyle endCap = D2DCapStyle.Flat);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawLines(HANDLE context, D2DPoint[] points, UINT count, D2DColor color,
			FLOAT weight = 1, D2DDashStyle dashStyle = D2DDashStyle.Solid);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawRectangle(HANDLE context, ref D2DRect rect, D2DColor color,
			FLOAT weight = 1, D2DDashStyle dashStyle = D2DDashStyle.Solid);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawRectangleWithPen(HANDLE context, ref D2DRect rect, HANDLE strokePen, FLOAT weight = 1);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void FillRectangle(HANDLE context, ref D2DRect rect, D2DColor color);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void FillRectangleWithBrush(HANDLE context, ref D2DRect rect, HANDLE brush);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawRoundedRect(HANDLE ctx, ref D2DRoundedRect roundedRect, D2DColor strokeColor, D2DColor fillColor, FLOAT strokeWidth = 1, D2DDashStyle strokeStyle = D2DDashStyle.Solid);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawRoundedRectWithBrush(HANDLE ctx, ref D2DRoundedRect roundedRect,
			HANDLE strokePen, HANDLE fillBrush, float strokeWidth = 1);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawEllipse(HANDLE context, ref D2DEllipse rect, D2DColor color,
			FLOAT width = 1, D2DDashStyle dashStyle = D2DDashStyle.Solid);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void FillEllipse(HANDLE context, ref D2DEllipse rect, D2DColor color);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void FillEllipseWithBrush(HANDLE ctx, ref D2DEllipse ellipse, HANDLE brush);

		#endregion // Simple Sharp

		#region Text

		[LibraryImport(DLL_NAME, EntryPoint = "DrawString", StringMarshalling = StringMarshalling.Utf16)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawText(HANDLE context, string text, D2DColor color,
			string fontName, FLOAT fontSize, D2DRect rect,
			D2DFontWeight fontWeight = D2DFontWeight.Normal,
			D2DFontStyle fontStyle = D2DFontStyle.Normal,
			D2DFontStretch fontStretch = D2DFontStretch.Normal,
			DWriteTextAlignment halign = DWriteTextAlignment.Leading,
			DWriteParagraphAlignment valign = DWriteParagraphAlignment.Near);

		[LibraryImport(DLL_NAME, EntryPoint = "MeasureText", StringMarshalling = StringMarshalling.Utf16)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void MeasureText(HANDLE ctx, string text, string fontName,
			FLOAT fontSize, ref D2DSize size,
			D2DFontWeight fontWeight = D2DFontWeight.Normal,
			D2DFontStyle fontStyle = D2DFontStyle.Normal,
			D2DFontStretch fontStretch = D2DFontStretch.Normal,
			DWriteTextAlignment halign = DWriteTextAlignment.Leading,
			DWriteParagraphAlignment valign = DWriteParagraphAlignment.Near);

		[LibraryImport(DLL_NAME, StringMarshalling = StringMarshalling.Utf16)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateFontFace(
			HANDLE context,
			in string fontName,
			in D2DFontWeight fontWeight = D2DFontWeight.Normal,
			in D2DFontStyle fontStyle = D2DFontStyle.Normal,
			in D2DFontStretch fontStretch = D2DFontStretch.Normal
		);

		[LibraryImport(DLL_NAME, StringMarshalling = StringMarshalling.Utf16)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DestroyFontFace(HANDLE fontFaceHandle);

		[LibraryImport(DLL_NAME, StringMarshalling = StringMarshalling.Utf16)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateTextPathGeometry(HANDLE ctx, string text, HANDLE fontFaceHandle, FLOAT fontSize);

		#endregion // Text

		#region Geometry

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateRectangleGeometry(HANDLE ctx, in D2DRect rect);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DestroyGeometry(HANDLE geometryContext);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateEllipseGeometry(HANDLE ctx, in D2DEllipse ellipse);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreatePathGeometry(HANDLE ctx);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateCombinedGeometry(HANDLE d2dCtx, HANDLE pathCtx1, HANDLE pathCtx2,
			D2D1_COMBINE_MODE combineMode, FLOAT flatteningTolerance = 10f);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DestroyPathGeometry(HANDLE ctx);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void FillGeometryWithBrush(HANDLE ctx, HANDLE geoHandle,
			HANDLE brushHandle, [Optional] HANDLE opacityBrushHandle);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawPolygon(HANDLE ctx, D2DPoint[] points, UINT count,
			D2DColor strokeColor, FLOAT strokeWidth, D2DDashStyle dashStyle, D2DColor fillColor);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawPolygonWithBrush(HANDLE ctx, D2DPoint[] points, UINT count,
			D2DColor strokeColor, FLOAT strokeWidth, D2DDashStyle dashStyle, HANDLE brushHandler);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void SetPathStartPoint(HANDLE ctx, D2DPoint startPoint);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void ClosePath(HANDLE ctx);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void AddPathLines(HANDLE path, D2DPoint[] points, uint count);
		public static void AddPathLines(HANDLE path, D2DPoint[] points) { AddPathLines(path, points, (uint)points.Length); }

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void AddPathBeziers(HANDLE ctx, D2DBezierSegment[] bezierSegments, uint count);

		public static void AddPathBeziers(HANDLE ctx, D2DBezierSegment[] bezierSegments)
		{
			AddPathBeziers(ctx, bezierSegments, (uint)bezierSegments.Length);
		}

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void AddPathEllipse(HANDLE path, ref D2DEllipse ellipse);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void AddPathArc(HANDLE ctx, D2DPoint endPoint, D2DSize size, FLOAT sweepAngle,
			D2DArcSize arcSize = D2DArcSize.Small,
			D2DSweepDirection sweepDirection = D2DSweepDirection.Clockwise);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawBeziers(
			HANDLE ctx,
			D2DBezierSegment[] bezierSegments,
			UINT count,
			D2DColor strokeColor, FLOAT strokeWidth = 1,
			D2DDashStyle dashStyle = D2DDashStyle.Solid
		);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawPath(HANDLE path, D2DColor strokeColor, FLOAT strokeWidth = 1, D2DDashStyle dashStyle = D2DDashStyle.Solid);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawPathWithPen(HANDLE path, HANDLE pen, FLOAT strokeWidth = 1);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void FillPathD(HANDLE path, D2DColor fillColor);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void FillGeometryWithBrush(HANDLE path, HANDLE brush);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static partial bool PathFillContainsPoint(HANDLE pathCtx, D2DPoint point);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static partial bool PathStrokeContainsPoint(HANDLE pathCtx, D2DPoint point, FLOAT strokeWidth = 1, D2DDashStyle dashStyle = D2DDashStyle.Solid);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void GetGeometryBounds(HANDLE pathCtx, ref D2DRect rect);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void GetGeometryTransformedBounds(HANDLE pathCtx, ref Matrix3x2 mat3x2, ref D2DRect rect);

		#endregion // Geometry

		#region Style
		[LibraryImport(DLL_NAME, EntryPoint = "CreateStrokeStyle")]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateStrokeStyle(HANDLE ctx, FLOAT[]? dashes = null, UINT dashCount = 0, FLOAT dashOffset = 0.0f, D2DCapStyle startCap = D2DCapStyle.Flat, D2DCapStyle endCap = D2DCapStyle.Flat);
		#endregion Style

		#region Pen
		[LibraryImport(DLL_NAME, EntryPoint = "CreatePenStroke")]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreatePen(HANDLE ctx, D2DColor strokeColor, D2DDashStyle dashStyle = D2DDashStyle.Solid, FLOAT[]? dashes = null, UINT dashCount = 0, FLOAT dashOffset = 0.0f);

		[LibraryImport(DLL_NAME, EntryPoint = "DestroyPenStroke")]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DestroyPen(HANDLE pen);
		#endregion Pen

		#region Brush

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateSolidColorBrush(HANDLE ctx, D2DColor color);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void SetSolidColorBrushColor(HANDLE brush, D2DColor color);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateLinearGradientBrush(HANDLE ctx, D2DPoint startPoint, D2DPoint endPoint,
																											D2DGradientStop[] gradientStops, UINT gradientStopCount);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateRadialGradientBrush(HANDLE ctx, D2DPoint origin, D2DPoint offset,
																													FLOAT radiusX, FLOAT radiusY, D2DGradientStop[] gradientStops,
																													UINT gradientStopCount);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void ReleaseBrush(HANDLE brushCtx);

		#endregion // Brush

		#region Bitmap
		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateBitmapFromHBitmap(HANDLE context, HANDLE hBitmap, [MarshalAs(UnmanagedType.Bool)] bool useAlphaChannel);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateBitmapFromBytes(HANDLE context, byte[] buffer, UINT offset, UINT length);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial HANDLE CreateBitmapFromMemory(HANDLE ctx, UINT width, UINT height, UINT stride, IntPtr buffer,
			UINT offset, UINT length);

		[LibraryImport(DLL_NAME, StringMarshalling = StringMarshalling.Utf16)]
		public static partial HANDLE CreateBitmapFromFile(HANDLE context, string filepath);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawD2DBitmap(HANDLE context, HANDLE bitmap);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawD2DBitmap(HANDLE context, HANDLE bitmap, ref D2DRect destRect);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawD2DBitmap(HANDLE context, HANDLE bitmap, ref D2DRect destRect, ref D2DRect srcRect,
			FLOAT opacity = 1, D2DBitmapInterpolationMode interpolationMode = D2DBitmapInterpolationMode.Linear);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawGDIBitmap(HANDLE context, HANDLE bitmap, FLOAT opacity = 1,
			D2DBitmapInterpolationMode interpolationMode = D2DBitmapInterpolationMode.Linear);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void DrawGDIBitmapRect(
			HANDLE context,
			HANDLE bitmap,
			ref D2DRect destRect,
			ref D2DRect srcRect,
			FLOAT opacity = 1,
			[MarshalAs(UnmanagedType.Bool)] bool alpha = false,
			D2DBitmapInterpolationMode interpolationMode = D2DBitmapInterpolationMode.Linear
		);

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial D2DSize GetBitmapSize(HANDLE d2dbitmap);
		#endregion

		[LibraryImport(DLL_NAME)]
		[UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
		public static partial void TestDraw(HANDLE ctx);
	}
}
