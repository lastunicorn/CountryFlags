﻿// Country Flags
// Copyright (C) 2022-2024 Dust in the Wind
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

using DustInTheWind.SvgToXaml.Svg.Serialization;

namespace DustInTheWind.SvgToXaml.Svg;

public class SvgUse : SvgElement
{
    public HypertextReference Href { get; set; }

    public double X { get; set; }

    public double Y { get; set; }

    public SvgUse()
    {
    }

    internal SvgUse(Use use)
        : base(use)
    {
        if (use == null) throw new ArgumentNullException(nameof(use));

        Href = use.Href;
        X = use.X;
        Y = use.Y;
    }

    public SvgUseInheritanceCollection GetInheritanceList()
    {
        return new SvgUseInheritanceCollection(this);
    }

    public SvgElement GetReferencedElement()
    {
        Svg svg = GetParentSvg();
        return svg?.FindChild(Href.Id);
    }
}