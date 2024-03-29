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

namespace DustInTheWind.CountryFlags;

public static partial class Countries
{
    public static Country Zambia { get; } = new()
    {
        ShortName = "Zambia",
        FullName = "Republic of Zambia",
        IsoCodeAlpha2 = "ZM",
        IsoCodeAlpha3 = "ZMB",
        IsoCodeNumeric = "894",
        IsIndependent = true
    };

    public static Country Zimbabwe { get; } = new()
    {
        ShortName = "Zimbabwe",
        FullName = "Republic of Zimbabwe",
        IsoCodeAlpha2 = "ZW",
        IsoCodeAlpha3 = "ZWE",
        IsoCodeNumeric = "716",
        IsIndependent = true
    };
}