using Microsoft.EntityFrameworkCore;
using Q1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class RoomManager : Form
    {
        PE_PRN_Fall2023_MovieContext context = new PE_PRN_Fall2023_MovieContext();
        public RoomManager()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            List<Room> rooms = context.Rooms.ToList();

            cboRoom.DataSource = rooms;
            cboRoom.DisplayMember = "Title";
            cboRoom.ValueMember = "id";

            cboMovie.DataSource = context.Movies.ToList();
            cboMovie.DisplayMember = "Title";
            cboMovie.ValueMember = "id";

            cboTimeSlot.DataSource = context.TimeSlots.ToList();
            cboTimeSlot.DisplayMember = "TimeString";
            cboTimeSlot.ValueMember = "id";

            cboTimeSlot.DataSource = context.TimeSlots.ToList();
            cboTimeSlot.DisplayMember = "TimeString";
            cboTimeSlot.ValueMember = "id";

            LoadSchedule();
        }

        private void LoadSchedule()
        {
            List<Schedule> schedules = context.Schedules.Include(x => x.Room)
                .Include(x => x.Movie).Include(x => x.TimeSlot).ToList();

            if (cboRoom.SelectedValue != null)
            {
                schedules = schedules.Where(x => x.RoomId == ((Room)cboRoom.SelectedItem).Id).ToList();
            }

            dgvShow.DataSource = schedules.Select(x => new
            {
                x.Id,
                x.Room.Title,
                Movie = (x.Movie != null) ? x.Movie.Title : "",
                TimeSlot = (x.TimeSlot != null) ? x.TimeSlot.TimeString : "",
                x.StartDate,
                x.EndDate,
                x.Note
            }).ToList();

        }

        private void cboRoom_TextChanged(object sender, EventArgs e)
        {
            LoadSchedule();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = false;
            int idTimeSlot = ((TimeSlot) cboTimeSlot.SelectedItem).Id;
            int idRoom = ((Room) cboRoom.SelectedItem).Id;

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                check = true;
            }
            else
            {
                Schedule schedule = context.Schedules
                    .FirstOrDefault(x => x.StartDate <= dtpStartDate.Value && x.EndDate >= dtpStartDate.Value 
                    && x.TimeSlotId == idTimeSlot && x.RoomId == idRoom);
                if (schedule != null)
                {
                    check = true;
                }
            }

            if (check)
            {
                MessageBox.Show("The screening schedule does not meet the conditions and cannot be added to the database.");
                return;
            }
            else
            {
                Schedule schedule = new Schedule();
                schedule.TimeSlotId = idTimeSlot;
                schedule.RoomId = idRoom;
                schedule.StartDate = dtpStartDate.Value;
                schedule.EndDate = dtpEndDate.Value;
                schedule.MovieId = (cboMovie.SelectedItem as Movie).Id;

                context.Schedules.Add(schedule);
                context.SaveChanges();
                LoadSchedule();
            }
        }
    }
}
