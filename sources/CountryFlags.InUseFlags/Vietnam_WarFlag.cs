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

public class Vietnam_WarFlag : CountryFlag
{
    public Vietnam_WarFlag()
    {
        Country = Countries.Vietnam;

        Id = "WarFlag";
        Names = new List<FlagName>
        {
            "War Flag"
        };
        Description = "A golden star centered on a red field, and yellow words Quyết thắng (Determining to win) in the upper canton.";
        Usage = FlagUsage.WarFlag;
    }
}