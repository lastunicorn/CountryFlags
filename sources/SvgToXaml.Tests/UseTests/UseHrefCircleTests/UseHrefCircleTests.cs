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

using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Tests.Utils;
using DustInTheWind.SvgToXaml.Tests.Utils.Assertions;

namespace DustInTheWind.SvgToXaml.Tests.UseTests.UseHrefCircleTests;

public class UseHrefCircleTests : SvgFileTestsBase
{
    [Fact]
    public void HavingUseReferencingCircleDeclaredBeforeIt_WhenSvgIsParsed_ThenTwoEllipsesAreCreated()
    {
        TestConvertSvgFile("use-href-circle-before.svg", canvas =>
        {
            TypeHierarchy expectedTypes = new()
            {
                typeof(Ellipse).ToHierarchyItem(),
                typeof(Ellipse).ToHierarchyItem()
            };

            canvas.Should().ContainExact(expectedTypes);
        });
    }

    [Fact]
    public void HavingUseReferencingCircleDeclaredAfterIt_WhenSvgIsParsed_ThenTwoEllipsesAreCreated()
    {
        TestConvertSvgFile("use-href-circle-after.svg", canvas =>
        {
            TypeHierarchy expectedTypes = new()
            {
                typeof(Ellipse).ToHierarchyItem(),
                typeof(Ellipse).ToHierarchyItem()
            };

            canvas.Should().ContainExact(expectedTypes);
        });
    }
}