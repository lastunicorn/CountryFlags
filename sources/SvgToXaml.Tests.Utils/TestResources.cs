// Country Flags
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

using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DustInTheWind.SvgToXaml.Tests.Utils;

public static class TestResources
{
    public static string ReadTextFile(string resourceFileName, Type relativeType)
    {
        if (relativeType == null) throw new ArgumentNullException(nameof(relativeType));

        Assembly assembly = relativeType.Assembly;
        string callerNamespace = relativeType.Namespace;

        using Stream stream = assembly.GetManifestResourceStream(callerNamespace + "." + resourceFileName);
        using StreamReader streamReader = new(stream);

        return streamReader.ReadToEnd();
    }

    public static string ReadTextFile(string resourceFileName)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        string callerNamespace = GetCallerNamespace();

        using Stream stream = assembly.GetManifestResourceStream(callerNamespace + "." + resourceFileName);
        using StreamReader streamReader = new(stream);

        return streamReader.ReadToEnd();
    }

    private static string GetCallerNamespace()
    {
        StackFrame stackFrame = new(2, false);
        MethodBase caller = stackFrame.GetMethod();
        Type callerType = caller.DeclaringType;

        return callerType.Namespace;
    }
}