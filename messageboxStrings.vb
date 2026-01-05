Module MessageboxStrings 'Messagebox strings

    Private stringsGerman As Dictionary(Of String, String) = New Dictionary(Of String, String) From
    {
        {"errorProfileDirectoryDoesNotExist", "Fehler: Profilverzeichnis existiert nicht. Bitte starte die App neu."},
        {"errorLoadingProfilesFailed", "Fehler: Konnte Profile nicht laden. Bitte versuche es erneut."},
        {"errorNoProfileSelected", "Fehler: Kein Profil ausgewählt. Bitte wähle ein anderes Profil aus, das geladen werden soll."},
        {"errorDefaultProfileNoLongerExists", "Fehler: Standardprofil existiert nicht mehr. Option wird automatisch deaktiviert."},
        {"errorDefaultProfileEmpty", "Fehler: Konnte Standardprofil nicht laden, da es leer ist. Option wird automatisch deaktiviert."},
        {"errorProfileDoesNotExist", "Fehler: Profil existiert nicht."},
        {"errorProfileNameIsEmpty", "Fehler: Profilname ist leer."},
        {"errorCouldntUpdateEmptyProfileName", "Fehler: Konnte Profil nicht aktualisieren, da der Name leer ist."},
        {"questionLoadOldOrCorruptedProfile", "Du versuchst ein Profil von einer älteren Version oder ein defektes Profil zu laden. Du musst es aktualisieren, um es zu laden. Du verlierst dabei normalerweise keine Einstellungen. Möchtest du fortfahren?"},
        {"questionProfileNameAlreadyExists", "Ein Profil mit diesem Namen existiert bereits. Möchtest du es überschreiben?"},
        {"infoLoadedAndUpdatedProfile", "Profil wurde geladen und aktualisiert. Es sollte nun funktionieren!"},
        {"infoCancelledLoadingProfiles", "Laden des Profils wurde abgebrochen."},
        {"infoDeletedProfile", "Profil wurde gelöscht."},
        {"infoUpdatedSelectedProfile", "Ausgewähltes Profil wurde aktualisiert."},
        {"infoProfileOverwrittenAndSaved", "Profil wurde überschrieben und gespeichert."},
        {"infoProfileNotOverwritten", "Profil wurde nicht überschrieben."},
        {"infoProfileSaved", "Profil wurde gespeichert."},
        {"infoSettingsSaved", "Einstellungen wurden gespeichert. Du musst die App möglicherweise neu starten, um die Änderungen anzuwenden."},
        {"infoProfileLoaded", "Profil wurde geladen."}
    }

    Private stringsEnglish As Dictionary(Of String, String) = New Dictionary(Of String, String) From
    {
        {"errorProfileDirectoryDoesNotExist", "Error: Profile directory does not exist. Please restart the application."},
        {"errorLoadingProfilesFailed", "Error: Could not load profiles. Please try again."},
        {"errorNoProfileSelected", "Error: No profile selected. Please select a profile to load from."},
        {"errorDefaultProfileNoLongerExists", "Error: Default profile no longer exists. Option will be disabled automatically."},
        {"errorDefaultProfileEmpty", "Error: Could not load default profile as it is empty. Option will be disabled automatically."},
        {"errorProfileDoesNotExist", "Error: Profile does not exist."},
        {"errorProfileNameIsEmpty", "Error: Profile name is empty."},
        {"errorCouldntUpdateEmptyProfileName", "Error: Couldn't update profile as the name is empty."},
        {"questionLoadOldOrCorruptedProfile", "You are trying to load a profile from an older version or a corrupted profile. You need to update it in order to load it. You usually won't lose any settings. Do you want to continue?"},
        {"questionProfileNameAlreadyExists", "A profile with this name already exists. Do you want to override it?"},
        {"infoLoadedAndUpdatedProfile", "Loaded and updated profile. It should now work correctly!"},
        {"infoCancelledLoadingProfiles", "Cancelled loading profile."},
        {"infoDeletedProfile", "Profile was deleted."},
        {"infoUpdatedSelectedProfile", "Updated the selected profile."},
        {"infoProfileOverwrittenAndSaved", "Profile was overwritten and saved."},
        {"infoProfileNotOverwritten", "Profile was not overwritten."},
        {"infoProfileSaved", "Profile was saved."},
        {"infoSettingsSaved", "Settings were saved. You may need to restart the application for changes to take effect."},
        {"infoProfileLoaded", "Profile was loaded."}
    }

    Public Function GetString(id As String, language As String) As String 'This function return the messagebox string for a specific case and language

        Dim out As String = ""

        'Try getting the translation from the dictionaries
        If language = "English" Then
            If stringsEnglish.TryGetValue(id, out) Then
                Return out
            End If
        ElseIf language = "German" Then
            If stringsGerman.TryGetValue(id, out) Then
                Return out
            End If
        End If

        Return "error"
    End Function
End Module
