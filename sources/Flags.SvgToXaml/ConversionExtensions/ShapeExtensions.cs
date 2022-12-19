﻿// Country Flags
// Copyright (C) 2022 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Windows.Media;
using System.Windows.Shapes;
using DustInTheWind.Flags.SvgToXaml.Svg;

namespace DustInTheWind.Flags.SvgToXaml.ConversionExtensions;

internal static class ShapeExtensions
{
    public static void UpdateFrom(this Shape shape, SvgElement svgElement)
    {
        if (svgElement.Fill == null)
        {
            shape.Fill = Brushes.Black;
        }
        else
        {
            if (string.Compare(svgElement.Fill, "none", StringComparison.OrdinalIgnoreCase) != 0)
                shape.Fill = (Brush)new BrushConverter().ConvertFrom(svgElement.Fill)!;
        }

        if (svgElement.Stroke != null && string.Compare(svgElement.Stroke, "none", StringComparison.OrdinalIgnoreCase) != 0)
            shape.Stroke = (Brush)new BrushConverter().ConvertFrom(svgElement.Stroke)!;

        if (svgElement.StrokeWidth != null)
            shape.StrokeThickness = svgElement.StrokeWidth.Value;

        if (svgElement.StrokeLineCap != null)
        {
            shape.StrokeStartLineCap = svgElement.StrokeLineCap switch
            {
                StrokeLineCap.Flat => PenLineCap.Flat,
                StrokeLineCap.Square => PenLineCap.Square,
                StrokeLineCap.Round => PenLineCap.Round,
                StrokeLineCap.Triangle => PenLineCap.Triangle,
                _ => throw new ArgumentOutOfRangeException()
            };

            shape.StrokeEndLineCap = svgElement.StrokeLineCap switch
            {
                StrokeLineCap.Flat => PenLineCap.Flat,
                StrokeLineCap.Square => PenLineCap.Square,
                StrokeLineCap.Round => PenLineCap.Round,
                StrokeLineCap.Triangle => PenLineCap.Triangle,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        if (svgElement.StrokeLineJoin != null)
        {
            shape.StrokeLineJoin = svgElement.StrokeLineJoin switch
            {
                StrokeLineJoin.Miter => PenLineJoin.Miter,
                StrokeLineJoin.Bevel => PenLineJoin.Bevel,
                StrokeLineJoin.Round => PenLineJoin.Round,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        if (svgElement.StrokeDashOffset != null)
            shape.StrokeDashOffset = svgElement.StrokeDashOffset.Value;
    }
}