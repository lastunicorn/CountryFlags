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

public class Egypt_PresidentFlag : CountryFlag
{
    public Egypt_PresidentFlag()
    {
        Country = Countries.Egypt;

        Id = "President";
        Names = new List<FlagName>
        {
            "President's flag"
        };
        Description = "National flag with gold outlined Eagle of Saladin in canton.";
        StartDate = new FlagDate(1984, 10, 04);
        Usage = FlagUsage.LeaderFlag;
    }
}