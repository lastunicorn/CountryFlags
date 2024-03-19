﻿// Country Flags
// Copyright (C) 2022-2023 Dust in the Wind
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

using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.ConversionExtensions;

internal static class SvgLineExtensions
{
    public static Line ToXaml(this SvgLine svgLine)
    {
        Line line = new()
        {
            X1 = svgLine.X1,
            Y1 = svgLine.Y1,
            X2 = svgLine.X2,
            Y2 = svgLine.Y2,
        };

        line.UpdateFrom(svgLine);

        return line;
    }
}