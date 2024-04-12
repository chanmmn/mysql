select distinct ref.referenced_table_name Source_Table,
	tab.constraint_name,
	tab.constraint_type,
	tab.table_name  Target_Table
from information_schema.table_constraints tab,
	information_schema.referential_constraints ref
where tab.constraint_name = ref.constraint_name ORDER BY Source_Table;
