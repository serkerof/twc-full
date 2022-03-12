// @ts-nocheck
import { createSlice, createEntityAdapter, createAsyncThunk } from "@reduxjs/toolkit";

const emailAdapter = createEntityAdapter({
    selectId: (email) => email.id,
    sortComparer: (preEmail, nextEmail) => preEmail.id.localeCompare(nextEmail.id)
})

const initialState = {
    status: 'idle',
    error: null,
    checked: false,
    selectedEmail: {},
    emails: {
        ids: [],
        entities: {}
    }
}

export const fetchEmails = createAsyncThunk('emails/fetchEmails', async () => {
    try {
        const response = await fetch('/api/emails');
        return await response.json();
    } catch (error) {
        return error;
    }
})

export const fetchEmaliById = createAsyncThunk('emails/fetchEmaliById', async (id) => {
})

export const AddEmail = createAsyncThunk('emails/addEmail', async (email) => {
    try {
        const addedEmail = await fetch('/api/emails', {
            method: 'POST',
            body: JSON.stringify(email),
            headers: {
                'Content-Type': 'application/json'
            }
        }).then(response => response.json())
        return addedEmail
    }
    catch (error) {
        return error;
    }
})

export const updateEmailPassword = createAsyncThunk('emails/updateEmailPassword', async (email) => {
    try {
        const updatedEmail = await fetch('/api/emails/' + email.id, {
            method: 'PUT',
            body: JSON.stringify(email),
            headers: {
                'Content-Type': 'application/json'
            }
        }).then(response => response.json())
        return updatedEmail
    }
    catch (error) {
        return error;
    }
})

export const deleteEmail = createAsyncThunk('emails/deleteEmail', async (id) => {
    try {
        const response = await fetch('/api/emails/' + id, {
            method: 'DELETE'
        }).then(response => response.json())
        return response
    }
    catch (error) {
        return error;
    }
})

const sliceInvoker = () => {
    return {
        name: "emails",
        initialState,
        reducers: {
            setChecked: (state, action) => {
                state.checked = action.payload
            },  // setChecked
            setSelectedEmail: (state, action) => {
                state.selectedEmail = action.payload
            },  // setSelectedEmail
            setStatus: (state, action) => {
                state.status = action.payload
            },  // setStatus
        },
        extraReducers: {
            [fetchEmails.pending]: (state, action) => {
                state.status = 'loading';
            },
            [fetchEmails.fulfilled]: (state, action) => {
                emailAdapter.setAll(state, action.payload);
            },
        }
    }
}

const emailsSlice = createSlice(sliceInvoker());

export const {
    selectAll: selectAllEmails,
    selectById: selectEmailById,
    selectIds: selectAllEmailIds
} = emailAdapter.getSelectors(state => state.emails)

export const {
    setChecked,
    setSelectedEmail,
    setStatus
} = emailsSlice.actions

export default emailsSlice.reducer;