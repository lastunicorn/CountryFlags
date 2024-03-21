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

using System;
using Line = DustInTheWind.SvgToXaml.Svg.Serialization.Line;

namespace DustInTheWind.SvgToXaml.Svg;

public class SvgLine : SvgElement
{
    public double X1 { get; set; }

    public double Y1 { get; set; }

    public double X2 { get; set; }

    public double Y2 { get; set; }

    public SvgLine()
    {
    }

    internal SvgLine(Line line)
        : base(line)
    {
        if (line == null) throw new ArgumentNullException(nameof(line));

        X1 = line.X1;
        Y1 = line.Y1;
        X2 = line.X2;
        Y2 = line.Y2;
    }
}