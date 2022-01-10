﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;

namespace Squidex.ClientLibrary
{
    /// <summary>
    /// The request to change a status.
    /// </summary>
    public sealed record ChangeStatus
    {
        /// <summary>
        /// The new status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The due time.
        /// </summary>
        public DateTime? DueTime { get; set; }

        /// <summary>
        /// True to check referrers of this content.
        /// </summary>
        public bool CheckReferrers { get; set; }
    }

    /// <summary>
    /// The options for creating content items.
    /// </summary>
    public record struct ContentCreateOptions
    {
        /// <summary>
        /// The optional custom ID for the content item.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// If set to <c>true</c> the content will be published.
        /// </summary>
        public bool Publish { get; set; }
    }

    /// <summary>
    /// The options for upserting content items.
    /// </summary>
    public record struct ContentUpsertOptions
    {
        /// <summary>
        /// If set to <c>true</c> the content will be published.
        /// </summary>
        public bool Publish { get; set; }
    }

    /// <summary>
    /// The options for deleting content items.
    /// </summary>
    public record struct ContentDeleteOptions
    {
        /// <summary>
         /// True to delete the content permanently.
         /// </summary>
        public bool Permanent { get; set; }

        /// <summary>
        /// True to check referrers of this content.
        /// </summary>
        public bool CheckReferrers { get; set; }
    }

    /// <summary>
    /// The options for creating content drafts. Used for later.
    /// </summary>
    public readonly struct ContentCreateDraftOptions
    {
    }

    /// <summary>
    /// The options for deleting content drafts. Used for later.
    /// </summary>
    public readonly struct ContentDeleteDraftOptions
    {
    }

    /// <summary>
    /// The options for updating content items. Used for later.
    /// </summary>
    public readonly struct ContentUpdateOptions
    {
    }

    /// <summary>
    /// The options for patching content items. Used for later.
    /// </summary>
    public readonly struct ContentPatchOptions
    {
    }
}