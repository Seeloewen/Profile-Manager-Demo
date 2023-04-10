Public Class messageboxStrings 'Messagebox strings

    Public Function returnMessageboxString(stringVariant As String, language As String) As String 'This function return the messagebox string for a specific case and language

        'Strings for the English translation
        If language = "English" Then
            If stringVariant = "errorProfileDirectoryDoesNotExist" Then
                Return "Error: Profile directory does not exist. Please restart the application."
            ElseIf stringVariant = "errorLoadingProfilesFailed" Then
                Return "Error: Could not load profiles. Please try again."
            ElseIf stringVariant = "errorNoProfileSelected" Then
                Return "Error: No profile selected. Please select a profile to load from."
            ElseIf stringVariant = "errorDefaultProfileNoLongerExists" Then
                Return "Error: Default profile no longer exists. Option will be disabled automatically."
            ElseIf stringVariant = "errorDefaultProfileEmpty" Then
                Return "Error: Could not load default profile as it is empty. Option will be disabled automatically."
            ElseIf stringVariant = "errorProfileDoesNotExist" Then
                Return "Error: Profile does not exist."
            ElseIf stringVariant = "errorProfileNameIsEmpty" Then
                Return "Error: Profile name is empty."
            ElseIf stringVariant = "errorCouldntUpdateEmptyProfileName" Then
                Return "Error: Couldn't update profile as the name is empty."
            ElseIf stringVariant = "questionLoadOldOrCorruptedProfile" Then
                Return "You are trying to load a profile from an older version or a corrupted profile. You need to update it in order to load it. You usually won't lose any settings. Do you want to continue?"
            ElseIf stringVariant = "questionProfileNameAlreadyExists" Then
                Return "A profile with this name already exists. Do you want to override it?"
            ElseIf stringVariant = "infoLoadedAndUpdatedProfile" Then
                Return "Loaded and updated profile. It should now work correctly!"
            ElseIf stringVariant = "infoCancelledLoadingProfiles" Then
                Return "Cancelled loading profile."
            ElseIf stringVariant = "infoDeletedProfile" Then
                Return "Profile was deleted."
            ElseIf stringVariant = "infoUpdatedSelectedProfile" Then
                Return "Updated the selected profile."
            ElseIf stringVariant = "infoProfileOverwrittenAndSaved" Then
                Return "Profile was overwritten and saved."
            ElseIf stringVariant = "infoProfileNotOverwritten" Then
                Return "Profile was not overwritten."
            ElseIf stringVariant = "infoProfileSaved" Then
                Return "Profile was saved."
            ElseIf stringVariant = "infoSettingsSaved" Then
                Return "Settings were saved."
            Else
                'If the input string variant is invalid, output error string
                Return "errorInvalidStringVariant"
            End If

            'Strings for the German translation. Feel free to add or remove translations and languages however you like.
        ElseIf language = "German" Then
            If stringVariant = "errorProfileDirectoryDoesNotExist" Then
                Return "Fehler: Profilverzeichnis existiert nicht. Bitte starte die App neu."
            ElseIf stringVariant = "errorLoadingProfilesFailed" Then
                Return "Fehler: Konnte Profile nicht laden. Bitte versuche es erneut."
            ElseIf stringVariant = "errorNoProfileSelected" Then
                Return "Fehler: Kein Profil ausgewählt. Bitte wähle ein anderes Profil aus, das geladen werden soll."
            ElseIf stringVariant = "errorDefaultProfileNoLongerExists" Then
                Return "Fehler: Standartprofil existiert nicht mehr. Option wird automatisch deaktiviert."
            ElseIf stringVariant = "errorDefaultProfileEmpty" Then
                Return "Fehler: Konnte Standartprofil nicht laden, da es leer ist. Option wird automatisch deaktiviert."
            ElseIf stringVariant = "errorProfileDoesNotExist" Then
                Return "Fehler: Profil existiert nicht."
            ElseIf stringVariant = "errorProfileNameIsEmpty" Then
                Return "Fehler: Profilname ist leer."
            ElseIf stringVariant = "errorCouldntUpdateEmptyProfileName" Then
                Return "Fehler: Konnte Profil nicht aktualisieren, da der Name leer ist."
            ElseIf stringVariant = "questionLoadOldOrCorruptedProfile" Then
                Return "Du versucht ein Profil von einer älteren Version oder ein defektes Profil zu laden. Du musst es aktualisieren, um es zu laden. Du verlierst dabei normalerweise keine Einstellungen. Möchtest du fortfahren?"
            ElseIf stringVariant = "questionProfileNameAlreadyExists" Then
                Return "Ein Profil mit diesem Namen existiert bereits. Möchtest du es überschreiben?"
            ElseIf stringVariant = "infoLoadedAndUpdatedProfile" Then
                Return "Profil wurde geladen und aktualisiert. Es sollte nun funktionieren!"
            ElseIf stringVariant = "infoCancelledLoadingProfiles" Then
                Return "Laden des Profils wurde abgebrochen."
            ElseIf stringVariant = "infoDeletedProfile" Then
                Return "Profil wurde gelöscht."
            ElseIf stringVariant = "infoUpdatedSelectedProfile" Then
                Return "Ausgewähltes Profil wurde aktualisiert."
            ElseIf stringVariant = "infoProfileOverwrittenAndSaved" Then
                Return "Profil wurde überschrieben und gespeichert."
            ElseIf stringVariant = "infoProfileNotOverwritten" Then
                Return "Profil wurde nicht überschrieben."
            ElseIf stringVariant = "infoProfileSaved" Then
                Return "Profil wurde gespeichert."
            ElseIf stringVariant = "infoSettingsSaved" Then
                Return "Einstellungen wurden gespeichert."
            Else
                'If the input string variant is invalid, output error string
                Return "errorInvalidStringVariant"
            End If
            'If the input language is invalid, output error string
        Else
            Return "errorInvalidLanguage"
        End If
    End Function
End Class
