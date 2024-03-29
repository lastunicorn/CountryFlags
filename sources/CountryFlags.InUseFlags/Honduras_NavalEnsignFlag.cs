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

public class Honduras_NavalEnsignFlag : CountryFlag
{
    public Honduras_NavalEnsignFlag()
    {
        Country = Countries.Honduras;

        Id = "NavalEnsign";
        Names = new List<FlagName>
        {
            "Naval ensign"
        };
        Description = "A horizontal triband of blue (top and bottom) and white with the National Coat of Arms above an inverted arc of five blue five-pointed stars centered on the white band.";
        Usage = FlagUsage.NationalEnsign;
    }
}