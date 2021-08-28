using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace QuizQuestionsFront.Pages
{
    public partial class PersonalizedProgressBarsQuestions : ComponentBase
    {
        private const int TIME_TO_RESPOND_SECONDS = 90;

        [CascadingParameter]
        public int CurrentQuestionNumber { get; set; }

        [CascadingParameter]
        public bool IsLastQuestion { get; set; }

        [Parameter]
        public EventCallback FinisgQuizCallBack { get; set; }

        [Parameter]
        public EventCallback NextQuestionCallBack { get; set; }

        [Parameter]
        public int NumberOfqustions { get; set; }

        private Blazorise.Color ColorProgressBar { get; set; } = Blazorise.Color.Success;

        private int ProgressTimerValue { get; set; } = 0;
        private Timer progressTimer;
        private DateTime ProgessStartDateTime;
        private DateTime ProgessCurrentDateTime;


        protected override async Task OnInitializedAsync()
        {
            SetTimer();
            await base.OnInitializedAsync();
        }

        private void SetTimer()
        {
            ProgessStartDateTime = DateTime.Now;
            ProgessCurrentDateTime = ProgessStartDateTime;

            progressTimer = new Timer(1000);
            progressTimer.Elapsed += SetProgressValue;
            progressTimer.Start();
        }

        private void SetProgressValue(Object source, ElapsedEventArgs e)
        {
            ProgessCurrentDateTime = DateTime.Now;

            int currentSeconds = Convert.ToInt32(Math.Truncate((ProgessCurrentDateTime - ProgessStartDateTime).TotalSeconds));
            ProgressTimerValue = ((currentSeconds * 100) / TIME_TO_RESPOND_SECONDS);
                        
            if (IsLastQuestion && currentSeconds >= (TIME_TO_RESPOND_SECONDS + 1))
            {
                StopTimmer();
                FinisgQuizCallBack.InvokeAsync();
            }
            else if (currentSeconds >= (TIME_TO_RESPOND_SECONDS + 1))
            {
                ResetVariablesTimmer();
                NextQuestionCallBack.InvokeAsync();
            }

            ChangeColorProgressBar();
            StateHasChanged();
        }

        private void StopTimmer()
        {
            progressTimer.Stop();
            progressTimer.Close();
            progressTimer.Dispose();
        }

        private void ResetVariablesTimmer() 
        {
            ProgressTimerValue = 0;
            ProgessStartDateTime = DateTime.Now;
            ProgessCurrentDateTime = ProgessStartDateTime;
        }

        private void ChangeColorProgressBar() 
        {
            if (ProgressTimerValue < 25)
                ColorProgressBar = Blazorise.Color.Success;
            else if (ProgressTimerValue < 75)
                ColorProgressBar = Blazorise.Color.Info;
            else
                ColorProgressBar = Blazorise.Color.Danger;
        }

        private int GetProgressBarValueQuestions() => (((NumberOfqustions * 100) / NumberOfqustions) / NumberOfqustions) * (CurrentQuestionNumber);

    }
}
