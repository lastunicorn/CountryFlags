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

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class BangladeshFlag : CountryFlag
{
    public BangladeshFlag()
    {
        Country = Countries.Bangladesh;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "লাল সবুজ",
                Romanized = "Lal Shôbuz",
                EnglishTranslation = "The Red & Green"
            }
        };
        Description = "A red disc slightly off center to the left defacing a dark green banner.";
        StartDate = new FlagDate(1972, 01, 17);
        DesignedBy = "Quamrul Hassan";
        Usage = FlagUsage.NationalFlag;
    }
}