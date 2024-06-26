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

public class UkraineFlag : CountryFlag
{
    public UkraineFlag()
    {
        Country = Countries.Ukraine;

        Description = "A horizontal bicolour of blue and yellow.";
        StartDate = new FlagDate(2006, 09, 01);
        OtherDates = new List<FlagDate>
        {
            new(1918, 03, 22)
            {
                Description = "officially adopted"
            },
            new(1991, 08, 24)
            {
                Description = "de facto restored"
            },
            new(1992, 01, 28)
            {
                Description = "officially restored, current design"
            }
        };
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign;
    }
}