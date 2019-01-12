// Copyright (c) Xenko contributors (https://xenko.com)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
namespace Xenko.CodeOnlySample.NetCore
{
    class Xenko_CodeOnlySampleApp
    {
        static void Main(string[] args)
        {
            using (var game = new CodeOnlyGame())
            {
                game.Run();
            }
        }
    }
}
