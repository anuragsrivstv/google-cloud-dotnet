// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcrv = Google.Cloud.Run.V2;
using sys = System;

namespace Google.Cloud.Run.V2
{
    /// <summary>Resource name for the <c>Revision</c> resource.</summary>
    public sealed partial class RevisionName : gax::IResourceName, sys::IEquatable<RevisionName>
    {
        /// <summary>The possible contents of <see cref="RevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>.
            /// </summary>
            ProjectLocationServiceRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceRevision = new gax::PathTemplate("projects/{project}/locations/{location}/services/{service}/revisions/{revision}");

        /// <summary>Creates a <see cref="RevisionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RevisionName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static RevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RevisionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RevisionName"/> constructed from the provided ids.</returns>
        public static RevisionName FromProjectLocationServiceRevision(string projectId, string locationId, string serviceId, string revisionId) =>
            new RevisionName(ResourceNameType.ProjectLocationServiceRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceId, string revisionId) =>
            FormatProjectLocationServiceRevision(projectId, locationId, serviceId, revisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceRevision(string projectId, string locationId, string serviceId, string revisionId) =>
            s_projectLocationServiceRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>Parses the given resource name string into a new <see cref="RevisionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="revisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RevisionName"/> if successful.</returns>
        public static RevisionName Parse(string revisionName) => Parse(revisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RevisionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="revisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RevisionName"/> if successful.</returns>
        public static RevisionName Parse(string revisionName, bool allowUnparsed) =>
            TryParse(revisionName, allowUnparsed, out RevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="revisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RevisionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string revisionName, out RevisionName result) => TryParse(revisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RevisionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="revisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RevisionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string revisionName, bool allowUnparsed, out RevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(revisionName, nameof(revisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceRevision.TryParseName(revisionName, out resourceName))
            {
                result = FromProjectLocationServiceRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(revisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string revisionId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RevisionId = revisionId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RevisionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/revisions/{revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        public RevisionName(string projectId, string locationId, string serviceId, string revisionId) : this(ResourceNameType.ProjectLocationServiceRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Revision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RevisionId { get; }

        /// <summary>
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceRevision: return s_projectLocationServiceRevision.Expand(ProjectId, LocationId, ServiceId, RevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RevisionName);

        /// <inheritdoc/>
        public bool Equals(RevisionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RevisionName a, RevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RevisionName a, RevisionName b) => !(a == b);
    }

    public partial class GetRevisionRequest
    {
        /// <summary>
        /// <see cref="gcrv::RevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RevisionName RevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRevisionsRequest
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ServiceName ParentAsServiceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServiceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRevisionRequest
    {
        /// <summary>
        /// <see cref="gcrv::RevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RevisionName RevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Revision
    {
        /// <summary>
        /// <see cref="gcrv::RevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RevisionName RevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Service"/> resource name property.
        /// </summary>
        public ServiceName ServiceAsServiceName
        {
            get => string.IsNullOrEmpty(Service) ? null : ServiceName.Parse(Service, allowUnparsed: true);
            set => Service = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="EncryptionKey"/> resource name property.
        /// </summary>
        public CryptoKeyName EncryptionKeyAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(EncryptionKey) ? null : CryptoKeyName.Parse(EncryptionKey, allowUnparsed: true);
            set => EncryptionKey = value?.ToString() ?? "";
        }
    }
}