const roles = [
	{
		id: '0093f6b3-0e37-481f-b33d-5d1136a43a46',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: 'cfaf4dd8-9892-4b9b-9c6f-36fcc56bce56',
		application_id: '80c357d4-fdb0-4e6d-a5c5-89fda0ddefa5',
		role: {
			id: 'cfaf4dd8-9892-4b9b-9c6f-36fcc56bce56',
			name: 'juanchin',
			application_type: 'APPLICATION_DM'
		}
	},
	{
		id: '07105492-4412-43a1-9ff3-8faa27fbb555',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: '3bd8a3c3-b93f-45ef-8cba-3bfa000782a9',
		application_id: '80c357d4-fdb0-4e6d-a5c5-89fda0ddefa5',
		role: {
			id: '3bd8a3c3-b93f-45ef-8cba-3bfa000782a9',
			name: 'DM Admin',
			application_type: 'APPLICATION_DM'
		}
	},
	{
		id: '389321c3-e868-4560-9973-34a842959af6',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: '53d56a9e-a639-4977-b665-5414932cc269',
		application_id: '80c357d4-fdb0-4e6d-a5c5-89fda0ddefa5',
		role: {
			id: '53d56a9e-a639-4977-b665-5414932cc269',
			name: 'DM Full',
			application_type: 'APPLICATION_DM'
		}
	},
	{
		id: '69f0b1e8-ac07-4f53-9aac-d36b4f14cfe8',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: '9319400a-6b96-46f5-8449-20a9ae715172',
		application_id: '888871e6-649c-4471-86ce-d34a1863e382',
		role: {
			id: '9319400a-6b96-46f5-8449-20a9ae715172',
			name: '1 PLT405 Test 10 zach',
			application_type: 'APPLICATION_RBAC'
		}
	},
	{
		id: '7c44246d-85c8-49b5-b18e-999cf63933a2',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: 'dd433ae4-6711-4de6-8c51-4859613763c5',
		application_id: '888871e6-649c-4471-86ce-d34a1863e382',
		role: {
			id: 'dd433ae4-6711-4de6-8c51-4859613763c5',
			name: '1 role 1000',
			application_type: 'APPLICATION_RBAC'
		}
	},
	{
		id: '7cbd5ee5-91f8-4477-b7f8-c8e2808c9894',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: 'fb364d8a-2b7d-4065-90e9-9f3a1e93ff8e',
		application_id: '888871e6-649c-4471-86ce-d34a1863e382',
		role: {
			id: 'fb364d8a-2b7d-4065-90e9-9f3a1e93ff8e',
			name: 'Application ADM',
			application_type: 'APPLICATION_RBAC'
		}
	},
	{
		id: '87ab25b7-ed79-4506-87d8-6f648b6aa458',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: '2c0d1533-ecf6-4304-8a2e-ccde7396f4b0',
		application_id: '888871e6-649c-4471-86ce-d34a1863e382',
		role: {
			id: '2c0d1533-ecf6-4304-8a2e-ccde7396f4b0',
			name: '1 PLT405 Test 20',
			application_type: 'APPLICATION_RBAC'
		}
	},
	{
		id: '87db66fc-a015-4ff0-a10b-f85d5c1a5a20',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: 'c842f804-5d20-45d5-ba21-90a303608259',
		application_id: 'bc71ddc7-6dae-445a-ba68-0d4107763c27',
		role: {
			id: 'c842f804-5d20-45d5-ba21-90a303608259',
			name: 'MD Admin',
			application_type: 'APPLICATION_MD'
		}
	},
	{
		id: 'a7d05b91-2473-4ca2-a74b-8c118ca7b29d',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: '528f9ad2-885d-4940-95ba-4e3f675ea59d',
		application_id: '888871e6-649c-4471-86ce-d34a1863e382',
		role: {
			id: '528f9ad2-885d-4940-95ba-4e3f675ea59d',
			name: '1 new Role without Permissions',
			application_type: 'APPLICATION_RBAC'
		}
	},
	{
		id: 'd037f9d2-0f6e-4e0f-8214-95aeee4047e5',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: '69d5e612-fc74-470c-b68e-ea64ff0e69f4',
		application_id: '888871e6-649c-4471-86ce-d34a1863e382',
		role: {
			id: '69d5e612-fc74-470c-b68e-ea64ff0e69f4',
			name: 'AIM Super Admin',
			application_type: 'APPLICATION_RBAC'
		}
	},
	{
		id: 'e95e9ca1-0aa5-48ce-995c-cb4536a2393f',
		user_id: '3880bcd5-c81e-4c6d-b6b7-f0caf739d82b',
		role_id: '4755fb94-1e4d-42b9-bac1-5b8476924124',
		application_id: '80c357d4-fdb0-4e6d-a5c5-89fda0ddefa5',
		role: {
			id: '4755fb94-1e4d-42b9-bac1-5b8476924124',
			name: 'REM Admin',
			application_type: 'APPLICATION_DM'
		}
	}
];


const applicationId = 'bc71ddc7-6dae-445a-ba68-0d4107763c27'


//1 transform all objects in the array to 
/*
	{
		roleId: ...,
		roleName: ...,
		applicationId: ...,
		applicationType: ...
	}
*/


//2 devolver un array con solo las aplicaciones "APPLICATION_DM"




//3 verificar si existe en el array una applicacion con el id bc71ddc7-6dae-445a-ba68-0d4107763c27
// y el roleName MD Admin






























//1
const modifiedRoles = roles.map(item => {
	return {
		roleId: item.role.id,
		roleName: item.role.name,
		applicationId: item.application_id,
		applicationType: item.role.application_type
	}
});


//2
const dmApplications = roles.filter(item => {
	return item.role.application_type === 'APPLICATION_DM';
});

//3
const applicationAppears = roles.some(item => {
	return item.application_id === 'bc71ddc7-6dae-445a-ba68-0d4107763c27' &&
		item.role.name === 'MD Admin';
});
