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

namespace DustInTheWind.CountryFlags.InUseFlags;

public class Gibraltar_CivilEnsignFlag : CountryFlag
{
    public Gibraltar_CivilEnsignFlag()
    {
        Country = Countries.Gibraltar;

        Id = "CivilEnsign";
        Names = new List<FlagName>
        {
            "Civil ensign of Gibraltar"
        };
        Description = "Red Ensign with the Union Flag in the canton and the badge of Gibraltar in the fly.";
        StartDate = new FlagDate(1998);
        Usage = FlagUsage.CivilEnsign;
    }
}