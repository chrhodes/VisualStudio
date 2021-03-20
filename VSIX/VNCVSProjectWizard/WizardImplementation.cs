﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

using VNC;

namespace VNCVSProjectWizard
{
    public class WizardImplementation : IWizard
    {
        const string cAPPNAME = "VNCVSProjectWizard";

        private Form1 inputForm;

        // NOTE(crhodes)
        // Make these sharable across invocations, e.g. in Solution Template.

        private static string xxxAPPLICATIONxxx;
        private static string xxxMODULExxx;
        private static string xxxNAMESPACExxx;
        private static string xxxEVENTxxx;
        private static string xxxTYPExxx;
        private static string xxxITEMxxx;

        private static string xxxACTIONxxx;

        private static string xxxCUSTOM1xxx;
        private static string xxxCUSTOM2xxx;
        private static string xxxCUSTOM3xxx;
        private static string xxxCUSTOM4xxx;
        private static string xxxCUSTOM5xxx;

        private object currentAutomationObject;
        private object[] currentAutomationObjectParams;

        // 01

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            long startTicks = Log.Info("Enter", cAPPNAME);

            try
            {
                // Save stuff that we might be able to use later in a different method.
                currentAutomationObject = automationObject;
                currentAutomationObjectParams = customParams;

                foreach (var item in replacementsDictionary)
                {
                    Log.Trace($"Key: >{item.Key}< Value: >{item.Value}<", cAPPNAME, startTicks);
                }

                Log.Trace($"runKind: >{runKind}<", cAPPNAME, startTicks);

                foreach (var item in customParams)
                {
                    Log.Trace($"item: >{item}<", cAPPNAME, startTicks);
                }

                // Display a form to the user. The form collects
                // input for the custom replacementDictionary values.

                inputForm = new Form1();
                inputForm.lblTemplate.Text = $"item: >{customParams[0]}<";
                inputForm.Text = "VNC VS ProjectWizard";

                inputForm.Controls["txtAPPLICATION"].Text = xxxAPPLICATIONxxx;
                inputForm.Controls["txtMODULE"].Text = xxxMODULExxx;
                inputForm.Controls["txtNAMESPACE"].Text = xxxNAMESPACExxx;

                inputForm.Controls["txtTYPE"].Text = xxxTYPExxx;
                inputForm.Controls["txtEVENT"].Text = xxxEVENTxxx;
                inputForm.Controls["txtITEM"].Text = xxxITEMxxx;

                inputForm.Controls["txtACTION"].Text = xxxACTIONxxx;

                inputForm.Controls["txtCUSTOM1"].Text = xxxCUSTOM1xxx;
                inputForm.Controls["txtCUSTOM2"].Text = xxxCUSTOM2xxx;
                inputForm.Controls["txtCUSTOM3"].Text = xxxCUSTOM3xxx;
                inputForm.Controls["txtCUSTOM4"].Text = xxxCUSTOM4xxx;
                inputForm.Controls["txtCUSTOM5"].Text = xxxCUSTOM5xxx;

                inputForm.ShowDialog();

                xxxAPPLICATIONxxx = Form1.CustomAPPLICATION;
                xxxMODULExxx = Form1.CustomMODULE;

                xxxNAMESPACExxx = Form1.CustomNAMESPACE;

                xxxEVENTxxx = Form1.CustomEVENT;
                xxxTYPExxx = Form1.CustomTYPE;
                xxxITEMxxx = Form1.CustomITEM;

                xxxACTIONxxx = Form1.CustomACTION;

                xxxCUSTOM1xxx = Form1.CUSTOM1;
                xxxCUSTOM2xxx = Form1.CUSTOM2;
                xxxCUSTOM3xxx = Form1.CUSTOM3;
                xxxCUSTOM4xxx = Form1.CUSTOM4;
                xxxCUSTOM5xxx = Form1.CUSTOM5;

                Log.Trace($"xxxAPPLICATIONxxx: >{xxxAPPLICATIONxxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxMODULExxx: >{xxxMODULExxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxNAMESPACExxx: >{xxxNAMESPACExxx}<", cAPPNAME, startTicks);

                Log.Trace($"xxxEVENTxxx: >{xxxEVENTxxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxTYPExxx: >{xxxTYPExxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxITEMxxx: >{xxxITEMxxx}<", cAPPNAME, startTicks);

                Log.Trace($"xxxACTIONxxx: >{xxxACTIONxxx}<", cAPPNAME, startTicks);

                Log.Trace($"xxxCUSTOM1xxx: >{xxxCUSTOM1xxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxCUSTOM2xxx: >{xxxCUSTOM2xxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxCUSTOM3xxx: >{xxxCUSTOM3xxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxCUSTOM4xxx: >{xxxCUSTOM4xxx}<", cAPPNAME, startTicks);
                Log.Trace($"xxxCUSTOM5xxx: >{xxxCUSTOM5xxx}<", cAPPNAME, startTicks);


                // Add custom parameters.
                // Visual Studio handles the replacements inside the file based on these mappings

                replacementsDictionary.Add("$xxxAPPLICATIONxxx$", xxxAPPLICATIONxxx);
                replacementsDictionary.Add("$xxxMODULExxx$", xxxMODULExxx);

                if (xxxNAMESPACExxx.Length > 0)
                {
                    // Special handling for APPLICATION.NAMESPACE and MODULE.NAMESPACE
                    // Add a period in front of Namespace.

                    replacementsDictionary.Add("$xxxNAMESPACExxx$", $".{xxxNAMESPACExxx}");
                }
                else
                {
                    // Might still be using somewhere

                    replacementsDictionary.Add("$xxxNAMESPACExxx$", xxxNAMESPACExxx);
                }

                replacementsDictionary.Add("$xxxEVENTxxx$", xxxEVENTxxx);
                replacementsDictionary.Add("$xxxTYPExxx$", xxxTYPExxx);
                replacementsDictionary.Add("$xxxITEMxxx$", xxxITEMxxx);

                replacementsDictionary.Add("$xxxACTIONxxx$", xxxACTIONxxx);

                replacementsDictionary.Add("$xxxCUSTOM1xxx$", xxxCUSTOM1xxx);
                replacementsDictionary.Add("$xxxCUSTOM2xxx$", xxxCUSTOM2xxx);
                replacementsDictionary.Add("$xxxCUSTOM3xxx$", xxxCUSTOM3xxx);
                replacementsDictionary.Add("$xxxCUSTOM4xxx$", xxxCUSTOM4xxx);
                replacementsDictionary.Add("$xxxCUSTOM5xxx$", xxxCUSTOM5xxx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Log.Info("Exit", cAPPNAME, startTicks);
        }

        // 02

        public void ProjectFinishedGenerating(Project project)
        {
            long startTicks = Log.Trace($"Enter project.Name >{project?.Name ?? "null"}<", cAPPNAME);

            try
            {
                if (project is null)
                {
                    Log.Trace("project NULL ??", cAPPNAME, startTicks);
                }
                else
                {
                    RenameProjectItems(project.ProjectItems);
                    RenameProjectFile(project);
                }

            }
            catch (Exception ex)
            {
                Log.Error(ex, cAPPNAME);
            }

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        // 03

        // This method is called before opening any item that
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            long startTicks = Log.Trace("Enter", cAPPNAME);

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        // 04

        // This method is called after the project is created.
        public void RunFinished()
        {
            long startTicks = Log.Trace("Enter", cAPPNAME);

            Log.Trace("Exit", cAPPNAME, startTicks);
        }
        

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            long startTicks = Log.Trace("Enter", cAPPNAME);

            ReplaceTagsinFileName(projectItem);

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            long startTicks = Log.Trace($"Enter {filePath}", cAPPNAME);

            Log.Trace("Exit (true)", cAPPNAME, startTicks);

            return true;
        }

        void RenameProjectItems(ProjectItems projectItems)
        {
            long startTicks = Log.Trace("Enter", cAPPNAME);

            foreach (ProjectItem projectItem in projectItems)
            {
                Log.Trace($"projectItem: ({projectItem.Name})", cAPPNAME);

                // Recursively descend if the current item contains projectItems
                if (projectItem.ProjectItems.Count > 0) RenameProjectItems(projectItem.ProjectItems);

                var kind = projectItem.Kind;
                var name = projectItem.Name;

                //try
                //{
                //    var document = projectItem.Document;
                //}
                //catch (Exception ex)
                //{

                //}

                switch (projectItem.Kind)
                {
                    case "{6BB5F8EE-4483-11D3-8BCF-00C04F8EC28C}":
                        // Assembly.cs
                        ReplaceTagsinFileName(projectItem);
                        break;

                    case "{6BB5F8EF-4483-11D3-8BCF-00C04F8EC28C}":
                        // Properties
                        ReplaceTagsinFolderName(projectItem);
                        break;

                    default:

                        break;
                }

                if (!IsValidReplacementFileExtension(projectItem.Name)) continue;

                ReplaceTagsInProjectItem(projectItem);
            }

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        void ReplaceTagsinFileName(ProjectItem projectItem)
        {
            long startTicks = Log.Trace($"Enter projectItem.Name: >{projectItem.Name}<", cAPPNAME);

            if (!IsValidReplacementFileExtension(projectItem.Name)) return;

            ReplaceTagsInProjectItem(projectItem);

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        void ReplaceTagsinFolderName(ProjectItem projectItem)
        {
            long startTicks = Log.Trace($"Enter projectItem.Name: >{projectItem.Name}<", cAPPNAME);

            UpdateProjectItemName(projectItem, "APPLICATION", xxxAPPLICATIONxxx);
            UpdateProjectItemName(projectItem, "MODULE", xxxMODULExxx);

            // Special handling for APPLICATION.NAMESPACE and MODULE.NAMESPACE
            // Add a period in front of Namespace

            UpdateProjectItemName(projectItem, "NAMESPACE", $".{xxxNAMESPACExxx}");

            UpdateProjectItemName(projectItem, "TYPE", xxxTYPExxx);
            UpdateProjectItemName(projectItem, "ITEM", xxxITEMxxx);

            UpdateProjectItemName(projectItem, "ACTION", xxxACTIONxxx);

            // TODO(crhodes)
            // I don't see any reason to use CUSTOM{1,2,3,4,5} in Folder or File Names

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        private void UpdateProjectFolderName(ProjectItem projectItem, string PARAMETER, string xxxPARAMETERxxx)
        {
            projectItem.Name = projectItem.Name.Replace(PARAMETER, xxxPARAMETERxxx);
        }

        private void ReplaceTagsInProjectItem(ProjectItem projectItem)
        {
            long startTicks = Log.Trace($"Enter projectItem.Name: >{projectItem.Name}<", cAPPNAME);

            UpdateProjectItemName(projectItem, "APPLICATION", xxxAPPLICATIONxxx);
            UpdateProjectItemName(projectItem, "MODULE", xxxMODULExxx);

            // Special handling for APPLICATION.NAMESPACE and MODULE.NAMESPACE
            // Add a period in front of Namespace

            UpdateProjectItemName(projectItem, "NAMESPACE", $".{xxxNAMESPACExxx}");

            UpdateProjectItemName(projectItem, "TYPE", xxxTYPExxx);
            UpdateProjectItemName(projectItem, "ITEM", xxxITEMxxx);

            UpdateProjectItemName(projectItem, "ACTION", xxxACTIONxxx);

            UpdateProjectItemName(projectItem, "CUSTOM1", xxxCUSTOM1xxx);
            UpdateProjectItemName(projectItem, "CUSTOM2", xxxCUSTOM2xxx);
            UpdateProjectItemName(projectItem, "CUSTOM3", xxxCUSTOM3xxx);
            UpdateProjectItemName(projectItem, "CUSTOM4", xxxCUSTOM4xxx);
            UpdateProjectItemName(projectItem, "CUSTOM5", xxxCUSTOM5xxx);

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        private void UpdateProjectItemName(ProjectItem projectItem, string PARAMETER, string xxxPARAMETERxxx)
        {
            long startTicks = Log.Trace5($"Enter PARAMETER:({PARAMETER}) xxxPARAMETERxxx:({xxxPARAMETERxxx})", cAPPNAME);

            if (projectItem.Name.Contains(PARAMETER))
            {
                if (projectItem.Kind == "{66A26720-8FB5-11D2-AA7E-00C04F688DDE}") // Can just rename folders
                {
                    projectItem.Name = projectItem.Name.Replace(PARAMETER, xxxPARAMETERxxx);
                }
                else // Have to open and save files
                {
                    projectItem.Open();
                    projectItem.Name = projectItem.Name.Replace(PARAMETER, xxxPARAMETERxxx);
                    projectItem.Save();
                }
            }

            Log.Trace5($"Exit", cAPPNAME, startTicks);
        }

        bool IsValidReplacementFileExtension(string fileName)
        {
            long startTicks = Log.Trace($"Enter fileName: >{fileName}<", cAPPNAME);

            FileInfo fileInfo = new FileInfo(fileName);
            bool result = false;

            if (string.Equals(fileInfo.Extension, ".cs", StringComparison.OrdinalIgnoreCase)) result = true;
            if (string.Equals(fileInfo.Extension, ".csproj", StringComparison.OrdinalIgnoreCase)) result = true;
            if (string.Equals(fileInfo.Extension, ".xaml", StringComparison.OrdinalIgnoreCase)) result = true;
            if (string.Equals(fileInfo.Extension, ".config", StringComparison.OrdinalIgnoreCase)) result = true;
            if (string.Equals(fileInfo.Extension, ".txt", StringComparison.OrdinalIgnoreCase)) result = true;

            Log.Trace($"Exit {result}", cAPPNAME, startTicks);

            return result;
        }

        private void RenameProjectFile(Project project)
        {
            long startTicks = Log.Trace($"Enter project.Name >{project.Name}<", cAPPNAME);

            var originalName = project.Name;
            var originalFullName = project.FullName;
            var originalFileName = project.FileName;
            var originalParentProjectItem = project.ParentProjectItem;
            var originalProjectFolder = Path.GetDirectoryName(originalFileName);

            if (originalName.Contains("APPLICATION")
                || originalName.Contains("NAMESPACE")
                || originalName.Contains("TYPE") 
                || originalName.Contains("ITEM")
                || originalName.Contains("ACTION")
                )
            {
                string newProjectName = originalName.Replace("APPLICATION", xxxAPPLICATIONxxx);
                newProjectName = newProjectName.Replace("NAMESPACE", xxxNAMESPACExxx);
                newProjectName = newProjectName.Replace("TYPE", xxxTYPExxx);
                newProjectName = newProjectName.Replace("ITEM", xxxITEMxxx);
                newProjectName = newProjectName.Replace("ACTION", xxxACTIONxxx);

                project.Name = newProjectName;
                project.Save();
            }

            if (originalFileName.Contains("APPLICATION"))
            {
                project.SaveAs($"{originalProjectFolder}\\{project.Name}");
            }

            Log.Trace("Exit", cAPPNAME, startTicks);
            // This throws exception.  Sigh.  May have to do something more clever

            //if (originalFileName.Contains("APPLICATION"))
            //{
            //    project.Save(originalFileName.Replace("APPLICATION", customAPPLICATION));
            //}

        }
    }
}
