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

using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Tests.Utils;
using FluentAssertions;

namespace DustInTheWind.SvgToXaml.Tests.StrokeTests.GroupUseHrefCircleTests;

public class GroupUseHrefCircleFromDefsTests : SvgFileTestsBase
{
    [Fact]
    public void HavingStrokeDeclaredOnGroup_WhenSvgIsParsed_ThenResultedEllipseHasStrokeColorFromGroup()
    {
        TestConvertSvgFile("group^-use-href-defs-circle.svg", canvas =>
        {
            Ellipse ellipse = canvas
                .GetElementByIndex<Canvas>(0)
                .GetElementByIndex<Ellipse>(0);

            Color expectedColor = Color.FromArgb(0xff, 0x44, 0x55, 0x66);
            SolidColorBrush expectedBrush = new(expectedColor);
            ellipse.Stroke.Should().Be(expectedBrush, new SolidColorBrushComparer());
        });
    }

    [Fact]
    public void HavingStrokeDeclaredOnGroupAndOnUse_WhenSvgIsParsed_ThenResultedEllipseHasStrokeColorFromUse()
    {
        TestConvertSvgFile("group^-use^-href-defs-circle.svg", canvas =>
        {
            Ellipse ellipse = canvas
                .GetElementByIndex<Canvas>(0)
                .GetElementByIndex<Ellipse>(0);

            Color expectedColor = Color.FromArgb(0xff, 0x11, 0x22, 0x33);
            SolidColorBrush expectedBrush = new(expectedColor);
            ellipse.Stroke.Should().Be(expectedBrush, new SolidColorBrushComparer());
        });
    }

    [Fact]
    public void HavingStrokeDeclaredOnGroupOnUseAndOnCircle_WhenSvgIsParsed_ThenResultedEllipseHasStrokeColorFromUse()
    {
        TestConvertSvgFile("group^-use^-href-defs-circle^.svg", canvas =>
        {
            Ellipse ellipse = canvas
                .GetElementByIndex<Canvas>(0)
                .GetElementByIndex<Ellipse>(0);

            Color expectedColor = Color.FromArgb(0xff, 0x11, 0x22, 0x33);
            SolidColorBrush expectedBrush = new(expectedColor);
            ellipse.Stroke.Should().Be(expectedBrush, new SolidColorBrushComparer());
        });
    }
}