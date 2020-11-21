using System;
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
        private static string customAPPLICATION;
        private static string customEVENT;
        private static string customTYPE;

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
                inputForm.Text = $"item: >{customParams[0]}<";
                inputForm.Controls["txtAPPLICATION"].Text = customAPPLICATION;
                inputForm.Controls["txtTYPE"].Text = customTYPE;
                inputForm.Controls["txtEVENT"].Text = customEVENT;
                inputForm.ShowDialog();

                customAPPLICATION = Form1.CustomAPPLICATION;
                customEVENT = Form1.CustomEVENT;
                customTYPE = Form1.CustomTYPE;

                Log.Trace($"customAPPLICATION: >{customAPPLICATION}<", cAPPNAME, startTicks);
                Log.Trace($"customEVENT: >{customEVENT}<", cAPPNAME, startTicks);
                Log.Trace($"customTYPE: >{customTYPE}<", cAPPNAME, startTicks);

                // Add custom parameters.
                replacementsDictionary.Add("$customAPPLICATION$", customAPPLICATION);
                replacementsDictionary.Add("$customEVENT$", customEVENT);
                replacementsDictionary.Add("$customTYPE$", customTYPE);
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

            //ReplaceTagsInProjectItem(projectItem);
            if (projectItem.Name.Contains("APPLICATION"))
            {
                //projectItem.Open();
                projectItem.Name = projectItem.Name.Replace("APPLICATION", customAPPLICATION); ;
                //projectItem.Save();
            }

            if (projectItem.Name.Contains("TYPE"))
            {
                //projectItem.Open();
                projectItem.Name = projectItem.Name.Replace("TYPE", customTYPE); ;
                //projectItem.Save();
            }

            Log.Trace("Exit", cAPPNAME, startTicks);
        }

        private void ReplaceTagsInProjectItem(ProjectItem projectItem)
        {
            long startTicks = Log.Trace($"Enter projectItem.Name: >{projectItem.Name}<", cAPPNAME);

            if (projectItem.Name.Contains("APPLICATION"))
            {
                projectItem.Open();
                projectItem.Name = projectItem.Name.Replace("APPLICATION", customAPPLICATION);
                projectItem.Save();
            }

            if (projectItem.Name.Contains("TYPE"))
            {
                projectItem.Open();
                projectItem.Name = projectItem.Name.Replace("TYPE", customTYPE); ;
                projectItem.Save();
            }

            Log.Trace("Exit", cAPPNAME, startTicks);
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

            if (originalName.Contains("APPLICATION") || originalName.Contains("TYPE"))
            {
                string newProjectName = originalName.Replace("APPLICATION", customAPPLICATION);
                newProjectName = newProjectName.Replace("TYPE", customAPPLICATION);

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
