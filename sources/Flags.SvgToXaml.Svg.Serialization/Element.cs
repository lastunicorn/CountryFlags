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

using System.Xml.Serialization;

namespace DustInTheWind.Flags.SvgToXaml.Svg.Serialization;

public class Element
{
    [XmlAttribute("fill")]
    public string? Fill { get; set; }

    [XmlAttribute("stroke")]
    public string? Stroke { get; set; }

    [XmlAttribute("stroke-width")]
    public double StrokeWidth { get; set; }
    
    public bool StrokeWidthSpecified { get; set; }

    [XmlAttribute("stroke-linecap")]
    public string? StrokeLineCap { get; set; }

    [XmlAttribute("stroke-linejoin")]
    public string? StrokeLineJoin { get; set; }

    [XmlAttribute("stroke-dashoffset")]
    public double StrokeDashOffset { get; set; }
    
    public bool StrokeDashOffsetSpecified { get; set; }
}