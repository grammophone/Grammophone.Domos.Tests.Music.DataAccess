using Grammophone.DataAccess;
using Grammophone.Domos.DataAccess;
using Grammophone.Domos.Tests.Music.Domain;

namespace Grammophone.Domos.Tests.Music.DataAccess
{
	/// <summary>
	/// Provider-neutral music Domos domain container.
	/// </summary>
	public interface IMusicDomosDomainContainer : IWorkflowUsersDomainContainer<MusicUser, AlbumStateTransition>
	{
		/// <summary>Record labels.</summary>
		IEntitySet<RecordLabel> RecordLabels { get; }

		/// <summary>Record-label administrator dispositions.</summary>
		IEntitySet<RecordLabelAdministrator> RecordLabelAdministrators { get; }

		/// <summary>Record-label contributor dispositions.</summary>
		IEntitySet<RecordLabelContributor> RecordLabelContributors { get; }

		/// <summary>Artists.</summary>
		IEntitySet<Artist> Artists { get; }

		/// <summary>Albums.</summary>
		IEntitySet<Album> Albums { get; }

		/// <summary>Tracks.</summary>
		IEntitySet<Track> Tracks { get; }
	}
}
