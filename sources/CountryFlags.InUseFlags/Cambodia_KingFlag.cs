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

public class Cambodia_KingFlag : CountryFlag
{
    public Cambodia_KingFlag()
    {
        Country = Countries.Cambodia;

        Id = "King";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "King's Flag"
            }
        };
        Description = "The royal arms in gold centered on a blue field.";
        StartDate = new FlagDate(1993, 09, 24);
        Usage = FlagUsage.LeaderFlag;
    }
}