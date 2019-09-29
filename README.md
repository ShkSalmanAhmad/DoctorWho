# DoctorWho
Doctor Who is a long-running BBC television show that is unique in that the main character of The Doctor is periodically replaced by a different actor. In the show's 50+ years of history, there have been twelve (soon to be thirteen) actors to have played the title role. Over the years, The Doctor has taken on many companions who accompany him on his journeys through time and space.
 
Write a Windows Form App (.NET Framework) that:


    Makes use of a GUI interface that has menu options
    The File=>Open menu option displays an OpenFileDialog to allow the user to select a valid txt file
    Makes use of the OpenFileDialog.Filter property to allow only txt files to be selected
    Reads this data file containing three different record types, preceeded by a "D", "C", or "E"
        A "D" record refers to information about one of the Doctors
        A "C" record refers to information about one of the Companions
        An "E" record refers to information about one of the Episodes
    Uses three generic List<T> collections to store each of the three record types, using the Doctor, Companion, or Episode classes
    The left GroupBox contains a ComboBox that is loaded when the file is read
    The left GroupBox contains information pertaining to whichever Doctor has been selected in the ComboBox
    The right GroupBox contains a ListBox with each of the companions that has traveled with the selected Doctor
    The Doctor, Companion and Episode classes only need to have properties and a constructor, but you will need to analyze the data file to determine which fields each requires
    Notice that the Doctor and Companion records only have a StoryID, so you will need to use the appropriate LINQ statements to be able to match up the appropriate story Title
    You may NOT alter the provided data file in any way
