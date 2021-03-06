﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Templates.Analyzer.Types
{
    /// <summary>
    /// Contains all forms of an ARM template and information about the template
    /// </summary>
    public class TemplateContext
    {
        /// <summary>
        /// The original template parsed into JSON
        /// </summary>
        public JToken OriginalTemplate { get; set; }

        /// <summary>
        /// The template with resolved parameter/variable references and expressions
        /// </summary>
        public JToken ExpandedTemplate { get; set; }

        /// <summary>
        /// A unique identifier for the template
        /// </summary>
        public string TemplateIdentifier { get; set; }

        /// <summary>
        /// Whether this template is the top-level template in a deployment or nested within another template
        /// </summary>
        public bool IsMainTemplate { get; set; }
    }
}