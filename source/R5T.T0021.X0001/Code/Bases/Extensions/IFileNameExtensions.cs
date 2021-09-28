using System;

using R5T.T0021;
using R5T.T0021.X0001;


namespace System
{
    public static class IFileNameExtensions
    {
        public static string ProjectPlan(this IFileName _)
        {
            return FileNames.ProjectPlanText;
        }
    }
}
